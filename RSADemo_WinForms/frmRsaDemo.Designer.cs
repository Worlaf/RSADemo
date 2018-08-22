namespace RSADemo_WinForms
{
    partial class frmRsaDemo
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtPublicKeyPEM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExponent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModulus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateNewKeys = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKeySize = new System.Windows.Forms.TextBox();
            this.chUseMachineKeyStore = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMachineKeyStoreName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIssuerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.btnCreatePFX = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrivateKeyFriendlyName = new System.Windows.Forms.TextBox();
            this.btnImportPFX = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnShowImportPassword = new System.Windows.Forms.Button();
            this.txtImportPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblImportedCertificateInfo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtThumbprint = new System.Windows.Forms.TextBox();
            this.txtCreatedThumbprint = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnImportCertificateByThumbprint = new System.Windows.Forms.Button();
            this.cmbStoreName = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbStoreLocation = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.txtPublicKeyPEM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtExponent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtModulus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 244);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Public Key Data";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(701, 95);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "JSEncrypt Demo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtPublicKeyPEM
            // 
            this.txtPublicKeyPEM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublicKeyPEM.Location = new System.Drawing.Point(9, 111);
            this.txtPublicKeyPEM.Multiline = true;
            this.txtPublicKeyPEM.Name = "txtPublicKeyPEM";
            this.txtPublicKeyPEM.Size = new System.Drawing.Size(772, 127);
            this.txtPublicKeyPEM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Public key in PEM format to paste in JS Demo";
            // 
            // txtExponent
            // 
            this.txtExponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExponent.Location = new System.Drawing.Point(9, 72);
            this.txtExponent.Name = "txtExponent";
            this.txtExponent.Size = new System.Drawing.Size(772, 20);
            this.txtExponent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exponent";
            // 
            // txtModulus
            // 
            this.txtModulus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModulus.Location = new System.Drawing.Point(9, 32);
            this.txtModulus.Name = "txtModulus";
            this.txtModulus.Size = new System.Drawing.Size(772, 20);
            this.txtModulus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulus";
            // 
            // btnGenerateNewKeys
            // 
            this.btnGenerateNewKeys.Location = new System.Drawing.Point(12, 262);
            this.btnGenerateNewKeys.Name = "btnGenerateNewKeys";
            this.btnGenerateNewKeys.Size = new System.Drawing.Size(311, 23);
            this.btnGenerateNewKeys.TabIndex = 1;
            this.btnGenerateNewKeys.Text = "Generate new keys and copy public key to clipboard";
            this.btnGenerateNewKeys.UseVisualStyleBackColor = true;
            this.btnGenerateNewKeys.Click += new System.EventHandler(this.btnGenerateNewKeys_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Text to decrypt";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncrypted.Location = new System.Drawing.Point(6, 25);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(758, 100);
            this.txtEncrypted.TabIndex = 6;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(6, 131);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(170, 26);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecrypted.Location = new System.Drawing.Point(6, 163);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(758, 121);
            this.txtDecrypted.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key size";
            // 
            // txtKeySize
            // 
            this.txtKeySize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeySize.Location = new System.Drawing.Point(693, 262);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(100, 20);
            this.txtKeySize.TabIndex = 10;
            this.txtKeySize.Text = "1024";
            // 
            // chUseMachineKeyStore
            // 
            this.chUseMachineKeyStore.AutoSize = true;
            this.chUseMachineKeyStore.Location = new System.Drawing.Point(12, 291);
            this.chUseMachineKeyStore.Name = "chUseMachineKeyStore";
            this.chUseMachineKeyStore.Size = new System.Drawing.Size(138, 17);
            this.chUseMachineKeyStore.TabIndex = 11;
            this.chUseMachineKeyStore.Text = "Use Machine Key Store";
            this.chUseMachineKeyStore.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Machine Key Store Name";
            // 
            // txtMachineKeyStoreName
            // 
            this.txtMachineKeyStoreName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMachineKeyStoreName.Location = new System.Drawing.Point(12, 329);
            this.txtMachineKeyStoreName.Name = "txtMachineKeyStoreName";
            this.txtMachineKeyStoreName.Size = new System.Drawing.Size(781, 20);
            this.txtMachineKeyStoreName.TabIndex = 13;
            this.txtMachineKeyStoreName.Text = "test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "If using Machine Key Store and store with specified name \r\nalready exists, the ke" +
    "y from this store will be loaded. ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 355);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 442);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEncrypted);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnDecrypt);
            this.tabPage1.Controls.Add(this.txtDecrypted);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Decrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import & Export";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCreatedThumbprint);
            this.groupBox1.Controls.Add(this.txtPrivateKeyFriendlyName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnShowPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIssuerName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSubjectName);
            this.groupBox1.Controls.Add(this.btnCreatePFX);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create PFX";
            // 
            // txtIssuerName
            // 
            this.txtIssuerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIssuerName.Location = new System.Drawing.Point(9, 71);
            this.txtIssuerName.Name = "txtIssuerName";
            this.txtIssuerName.Size = new System.Drawing.Size(753, 20);
            this.txtIssuerName.TabIndex = 4;
            this.txtIssuerName.Text = "CN=example.org,O=exampleOrganization";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Issuer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Subject Name";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubjectName.Location = new System.Drawing.Point(9, 32);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(753, 20);
            this.txtSubjectName.TabIndex = 1;
            this.txtSubjectName.Text = "CN=example.org,O=exampleOrganization";
            // 
            // btnCreatePFX
            // 
            this.btnCreatePFX.Location = new System.Drawing.Point(6, 146);
            this.btnCreatePFX.Name = "btnCreatePFX";
            this.btnCreatePFX.Size = new System.Drawing.Size(128, 23);
            this.btnCreatePFX.TabIndex = 0;
            this.btnCreatePFX.Text = "Create PFX file";
            this.btnCreatePFX.UseVisualStyleBackColor = true;
            this.btnCreatePFX.Click += new System.EventHandler(this.btnCreatePFX_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(140, 105);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(75, 23);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.Text = "Show";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Private key friendly name";
            // 
            // txtPrivateKeyFriendlyName
            // 
            this.txtPrivateKeyFriendlyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrivateKeyFriendlyName.Location = new System.Drawing.Point(224, 107);
            this.txtPrivateKeyFriendlyName.Name = "txtPrivateKeyFriendlyName";
            this.txtPrivateKeyFriendlyName.Size = new System.Drawing.Size(538, 20);
            this.txtPrivateKeyFriendlyName.TabIndex = 9;
            this.txtPrivateKeyFriendlyName.Text = "Common purpose private key";
            // 
            // btnImportPFX
            // 
            this.btnImportPFX.Location = new System.Drawing.Point(9, 19);
            this.btnImportPFX.Name = "btnImportPFX";
            this.btnImportPFX.Size = new System.Drawing.Size(125, 38);
            this.btnImportPFX.TabIndex = 3;
            this.btnImportPFX.Text = "Import PFX file";
            this.btnImportPFX.UseVisualStyleBackColor = true;
            this.btnImportPFX.Click += new System.EventHandler(this.btnImportPFX_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnShowImportPassword
            // 
            this.btnShowImportPassword.Location = new System.Drawing.Point(274, 31);
            this.btnShowImportPassword.Name = "btnShowImportPassword";
            this.btnShowImportPassword.Size = new System.Drawing.Size(75, 23);
            this.btnShowImportPassword.TabIndex = 10;
            this.btnShowImportPassword.Text = "Show";
            this.btnShowImportPassword.UseVisualStyleBackColor = true;
            this.btnShowImportPassword.Click += new System.EventHandler(this.btnShowImportPassword_Click);
            // 
            // txtImportPassword
            // 
            this.txtImportPassword.Location = new System.Drawing.Point(140, 33);
            this.txtImportPassword.Name = "txtImportPassword";
            this.txtImportPassword.Size = new System.Drawing.Size(128, 20);
            this.txtImportPassword.TabIndex = 9;
            this.txtImportPassword.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Password";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmbStoreLocation);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cmbStoreName);
            this.groupBox3.Controls.Add(this.btnImportCertificateByThumbprint);
            this.groupBox3.Controls.Add(this.txtThumbprint);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblImportedCertificateInfo);
            this.groupBox3.Controls.Add(this.btnImportPFX);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnShowImportPassword);
            this.groupBox3.Controls.Add(this.txtImportPassword);
            this.groupBox3.Location = new System.Drawing.Point(5, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 141);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import PFX File";
            // 
            // lblImportedCertificateInfo
            // 
            this.lblImportedCertificateInfo.AutoSize = true;
            this.lblImportedCertificateInfo.Location = new System.Drawing.Point(6, 102);
            this.lblImportedCertificateInfo.Name = "lblImportedCertificateInfo";
            this.lblImportedCertificateInfo.Size = new System.Drawing.Size(0, 13);
            this.lblImportedCertificateInfo.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Thumbprint";
            // 
            // txtThumbprint
            // 
            this.txtThumbprint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThumbprint.Location = new System.Drawing.Point(140, 79);
            this.txtThumbprint.Name = "txtThumbprint";
            this.txtThumbprint.Size = new System.Drawing.Size(209, 20);
            this.txtThumbprint.TabIndex = 13;
            // 
            // txtCreatedThumbprint
            // 
            this.txtCreatedThumbprint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatedThumbprint.Location = new System.Drawing.Point(224, 149);
            this.txtCreatedThumbprint.Name = "txtCreatedThumbprint";
            this.txtCreatedThumbprint.ReadOnly = true;
            this.txtCreatedThumbprint.Size = new System.Drawing.Size(538, 20);
            this.txtCreatedThumbprint.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Thumbprint";
            // 
            // btnImportCertificateByThumbprint
            // 
            this.btnImportCertificateByThumbprint.Location = new System.Drawing.Point(9, 63);
            this.btnImportCertificateByThumbprint.Name = "btnImportCertificateByThumbprint";
            this.btnImportCertificateByThumbprint.Size = new System.Drawing.Size(125, 36);
            this.btnImportCertificateByThumbprint.TabIndex = 14;
            this.btnImportCertificateByThumbprint.Text = "Find Certificate by Thumbprint";
            this.btnImportCertificateByThumbprint.UseVisualStyleBackColor = true;
            this.btnImportCertificateByThumbprint.Click += new System.EventHandler(this.btnImportCertificateByThumbprint_Click);
            // 
            // cmbStoreName
            // 
            this.cmbStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStoreName.FormattingEnabled = true;
            this.cmbStoreName.Location = new System.Drawing.Point(355, 79);
            this.cmbStoreName.Name = "cmbStoreName";
            this.cmbStoreName.Size = new System.Drawing.Size(121, 21);
            this.cmbStoreName.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(352, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Store Name";
            // 
            // cmbStoreLocation
            // 
            this.cmbStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStoreLocation.FormattingEnabled = true;
            this.cmbStoreLocation.Location = new System.Drawing.Point(482, 79);
            this.cmbStoreLocation.Name = "cmbStoreLocation";
            this.cmbStoreLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbStoreLocation.TabIndex = 17;
            this.cmbStoreLocation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(479, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Store Location";
            // 
            // frmRsaDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 809);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMachineKeyStoreName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chUseMachineKeyStore);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerateNewKeys);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmRsaDemo";
            this.Text = "RSA Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPublicKeyPEM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExponent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModulus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateNewKeys;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.CheckBox chUseMachineKeyStore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMachineKeyStoreName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreatePFX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIssuerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrivateKeyFriendlyName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImportPFX;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnShowImportPassword;
        private System.Windows.Forms.TextBox txtImportPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtThumbprint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblImportedCertificateInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCreatedThumbprint;
        private System.Windows.Forms.Button btnImportCertificateByThumbprint;
        private System.Windows.Forms.ComboBox cmbStoreName;
        private System.Windows.Forms.ComboBox cmbStoreLocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

