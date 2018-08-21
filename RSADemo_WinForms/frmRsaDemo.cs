using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

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
    }
}