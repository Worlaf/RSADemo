using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace RSADemo_WinForms
{
    // DEMO of using RSACryptoServiceProvider with JSEncrypt lib (https://github.com/travist/jsencrypt)
    // RSACryptoServiceProvider uses "raw" keys representation (see https://msdn.microsoft.com/ru-ru/library/system.security.cryptography.rsaparameters(v=vs.110).aspx)
    // JSEncrypt uses "PEM" keys format (see https://tls.mbed.org/kb/cryptography/asn1-key-structures-in-der-and-pem, https://etherhack.co.uk/asymmetric/docs/rsa_key_breakdown.html)
    // So, workflow could be following:
    // Generate keys by creation of new instance of RSACryptoServiceProvider with preferred key size
    // Keys can be exported and imported using XML (RSACryptoServiceProvider.FromXmlString and RSACryptoServiceProvider.ToXmlString)
    // CspParameters can be used as more secure way to store keys (https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.cspparameters?view=netframework-4.7.2)
    // Create PEM-formatted string to use with JSEncrypt (see RSAUtil.ExportPublicKeyToPemString, code from here https://stackoverflow.com/questions/28406888/c-sharp-rsa-public-key-output-not-correct/28407693#28407693)
    //
    // On client side:
    // var encrypt = new JSEncrypt(); 
    // encrypt.setKey(publicKey); // use PEM-formatted key
    // var encryptedBase64String = encrypt.encrypt(textToEncrypt);
    // 
    // So, now we have series of bytes in base64 format
    // Convert base64 string to byte array: Convert.FromBase64String
    // Decrypt byte array: RSACryptoServiceProvider.Decrypt
    // Obtain Utf8 string if needed: Encoding.UTF8.GetString
    public partial class frmRsaDemo : Form
    {
        private RSACryptoServiceProvider rsaProvider;

        public frmRsaDemo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var keySize = Properties.Settings.Default.KeySize;
            if (!Properties.Settings.Default.UseMachineKeyStore)
            {
                if (Properties.Settings.Default.RSAParametersXML != null && Properties.Settings.Default.RSAParametersXML.Length > 1)
                {
                    rsaProvider = new RSACryptoServiceProvider(keySize);
                    rsaProvider.FromXmlString(Properties.Settings.Default.RSAParametersXML);
                }
                else
                    GenerateKeysAndSaveSettings(keySize);
            }
            else
                rsaProvider = GetOrCreateRsaProviderUsingStoredParameters(Properties.Settings.Default.MachineKeyStoreContainerName, keySize);

            UpdateUi();

            foreach (var enumValue in Enum.GetValues(typeof(StoreName)))
            {
                cmbStoreName.Items.Add(enumValue);
            }

            foreach (var enumValue in Enum.GetValues(typeof(StoreLocation)))
            {
                cmbStoreLocation.Items.Add(enumValue);
            }

            cmbStoreName.SelectedItem = StoreName.My;
            cmbStoreLocation.SelectedItem = StoreLocation.LocalMachine;
        }

        private void btnGenerateNewKeys_Click(object sender, EventArgs e)
        {
            var keySize = Properties.Settings.Default.KeySize;
            int.TryParse(txtKeySize.Text, out keySize);

            try
            {
                GenerateKeysAndSaveSettings(keySize);

                UpdateUi();
                Clipboard.SetText(txtPublicKeyPEM.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                var encryptedBytes = Convert.FromBase64String(txtEncrypted.Text.Trim());
                var decryptedBytes = rsaProvider.Decrypt(encryptedBytes, false); // false because jsencrypt uses PKCS#1 padding
                var decryptedString = Encoding.UTF8.GetString(decryptedBytes);
                txtDecrypted.Text = decryptedString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateKeysAndSaveSettings(int keySize)
        {
            rsaProvider = chUseMachineKeyStore.Checked ? GetOrCreateRsaProviderUsingStoredParameters(txtMachineKeyStoreName.Text, keySize) : new RSACryptoServiceProvider(keySize);

            Properties.Settings.Default.UseMachineKeyStore = chUseMachineKeyStore.Checked;
            Properties.Settings.Default.MachineKeyStoreContainerName = txtMachineKeyStoreName.Text;
            Properties.Settings.Default.KeySize = keySize;
            Properties.Settings.Default.RSAParametersXML = rsaProvider.ToXmlString(true);
            Properties.Settings.Default.Save();
        }

        private RSACryptoServiceProvider GetOrCreateRsaProviderUsingStoredParameters(string storageName, int keySize)
        {
            // if KeyContainer with sotrageName exist then RSA key parameters will be loaded
            // if not, then new RSA key parameters will be created and stored
            // CspParameterFlags enum https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.cspproviderflags?view=netframework-4.7.2
            // I found stored keys here: C:\ProgramData\Microsoft\Crypto\RSA\MachineKeys
            var rsaParams = new CspParameters
            {
                KeyContainerName = storageName,
                Flags = CspProviderFlags.UseMachineKeyStore
            };
            return new RSACryptoServiceProvider(keySize, rsaParams);
        }

        private void UpdateUi()
        {
            var p = rsaProvider.ExportParameters(false);

            txtKeySize.Text = rsaProvider.KeySize.ToString();
            txtExponent.Text = RsaUtil.ByteArrayToString(p.Exponent);
            txtModulus.Text = RsaUtil.ByteArrayToString(p.Modulus);
            txtPublicKeyPEM.Text = RsaUtil.ExportPublicKeyToPemString(rsaProvider);

            chUseMachineKeyStore.Checked = Properties.Settings.Default.UseMachineKeyStore;
            txtMachineKeyStoreName.Text = Properties.Settings.Default.MachineKeyStoreContainerName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://worlaf.github.io/RSADemo/JS%20Demo/index.html");
        }

        private Org.BouncyCastle.X509.X509Certificate CreateCertificate(string issuerName, string subjectName)
        {
            var random = new SecureRandom();
            var generator = new X509V1CertificateGenerator();

            var serialNumber = BigIntegers.CreateRandomInRange(BigInteger.One, BigInteger.ValueOf(long.MaxValue), random);
            generator.SetSerialNumber(serialNumber);


            var privateKey = GetPrivateRsaAsymmetricKeyParameter();
            var publicKey = GetPublicRsaAsymmetricKeyParameter();

            var asn1SignatureFactory = new Asn1SignatureFactory(PkcsObjectIdentifiers.Sha1WithRsaEncryption.Id, privateKey, random);
            generator.SetPublicKey(publicKey);

            var subjectDN = new X509Name(subjectName);
            generator.SetSubjectDN(subjectDN);
            var issuerDN = new X509Name(issuerName);
            generator.SetIssuerDN(issuerDN);

            generator.SetNotAfter(DateTime.UtcNow.AddYears(10));
            generator.SetNotBefore(DateTime.UtcNow.AddYears(-1));

//            var authorityKeyIdentifier = new AuthorityKeyIdentifier(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey), new GeneralNames(new GeneralName(issuerDN)), serialNumber);
//            var subjectKeyIdentidifer = new SubjectKeyIdentifier(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey));

//            generator.AddExtension(X509Extensions.AuthorityKeyIdentifier, false, authorityKeyIdentifier);
//            generator.AddExtension(X509Extensions.SubjectKeyIdentifier, false, subjectKeyIdentidifer);
//            generator.AddExtension(X509Extensions.BasicConstraints.Id, true, new BasicConstraints(0));


            var cert = generator.Generate(asn1SignatureFactory);
            cert.CheckValidity(DateTime.UtcNow);
            cert.Verify(publicKey);

            return cert;
        }

        private byte[] CreatePfxFile(Org.BouncyCastle.X509.X509Certificate cert, AsymmetricKeyParameter privateKey, string password, string keyFriendlyName)
        {
            var certEntry = new X509CertificateEntry(cert);
            var friendlyName = cert.SubjectDN.ToString();

            var keyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(privateKey);
            var keyBytes = keyInfo.ToAsn1Object().GetEncoded();

            var builder = new Pkcs12StoreBuilder();
            builder.SetUseDerEncoding(true);
            var store = builder.Build();

            store.SetKeyEntry(keyFriendlyName, new AsymmetricKeyEntry(privateKey), new[] {certEntry});
            byte[] pfxBytes;

            using (var ms = new MemoryStream())
            {
                store.Save(ms, password.ToCharArray(), new SecureRandom());
                pfxBytes = ms.ToArray();
            }

            return Pkcs12Utilities.ConvertToDefiniteLength(pfxBytes);
        }

        private void btnCreatePFX_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "certificate.pfx";
            saveFileDialog1.DefaultExt = "pfx";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Personal Information Exchange (*.pfx)|*.pfx";
            var result = saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
                return;

            var cert = CreateCertificate(txtIssuerName.Text, txtSubjectName.Text);
            var bytes = CreatePfxFile(cert, GetPrivateRsaAsymmetricKeyParameter(), txtPassword.Text, txtPrivateKeyFriendlyName.Text);

            var certificate = new X509Certificate2(bytes, txtPassword.Text, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserKeySet);
            txtCreatedThumbprint.Text = certificate.Thumbprint;

            var fileName = saveFileDialog1.FileName;
            File.WriteAllBytes(fileName, bytes);

        }

        private AsymmetricKeyParameter GetPrivateRsaAsymmetricKeyParameter()
        {
            var rsaParams = rsaProvider.ExportParameters(true);
            return new RsaPrivateCrtKeyParameters(rsaParams.Modulus.ToBigInteger(), rsaParams.Exponent.ToBigInteger(), rsaParams.D.ToBigInteger(),
                rsaParams.P.ToBigInteger(), rsaParams.Q.ToBigInteger(), rsaParams.DP.ToBigInteger(), rsaParams.DQ.ToBigInteger(), rsaParams.InverseQ.ToBigInteger());
        }

        private AsymmetricKeyParameter GetPublicRsaAsymmetricKeyParameter()
        {
            var rsaParams = rsaProvider.ExportParameters(false);
            return new RsaKeyParameters(false, rsaParams.Modulus.ToBigInteger(), rsaParams.Exponent.ToBigInteger());
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            btnShowPassword.Text = txtPassword.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private void btnImportPFX_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Personal Information Exchange (*.pfx)|*.pfx";
            openFileDialog1.DefaultExt = "pfx";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var certificateBytes = File.ReadAllBytes(openFileDialog1.FileName);
                var certificate = new X509Certificate2(certificateBytes, txtImportPassword.Text, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserKeySet);

                ImportCertificate(certificate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnShowImportPassword_Click(object sender, EventArgs e)
        {
            txtImportPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            btnShowImportPassword.Text = txtImportPassword.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private void btnImportCertificateByThumbprint_Click(object sender, EventArgs e)
        {
            try
            {
                var certStore = new X509Store((StoreName) cmbStoreName.SelectedItem, (StoreLocation) cmbStoreLocation.SelectedItem);
                certStore.Open(OpenFlags.ReadOnly);

                if (certStore.Certificates.Count == 0)
                {
                    MessageBox.Show("There are no certificates in selected store");
                    return;
                }

                var certCollection = certStore.Certificates.Find(X509FindType.FindByThumbprint, txtThumbprint.Text, false);
                var certificate = certCollection[0];

                ImportCertificate(certificate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ImportCertificate(X509Certificate2 certificate)
        {
            rsaProvider = (RSACryptoServiceProvider)certificate.PrivateKey;
            UpdateUi();

            txtThumbprint.Text = certificate.Thumbprint;
            lblImportedCertificateInfo.Text = $"Friendly name: {certificate.FriendlyName}; Issuer: {certificate.Issuer}; Subject: {certificate.Subject}; Signature algorithm: {certificate.SignatureAlgorithm.FriendlyName}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}