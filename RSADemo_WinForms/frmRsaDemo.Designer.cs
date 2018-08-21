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
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(823, 244);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Public Key Data";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(731, 95);
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
            this.txtPublicKeyPEM.Size = new System.Drawing.Size(808, 127);
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
            this.txtExponent.Size = new System.Drawing.Size(808, 20);
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
            this.txtModulus.Size = new System.Drawing.Size(808, 20);
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
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Text to decrypt";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncrypted.Location = new System.Drawing.Point(12, 368);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(823, 127);
            this.txtEncrypted.TabIndex = 6;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(12, 501);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(170, 23);
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
            this.txtDecrypted.Location = new System.Drawing.Point(12, 530);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(823, 116);
            this.txtDecrypted.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key size";
            // 
            // txtKeySize
            // 
            this.txtKeySize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeySize.Location = new System.Drawing.Point(729, 262);
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
            this.txtMachineKeyStoreName.Size = new System.Drawing.Size(823, 20);
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
            // frmRsaDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 658);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMachineKeyStoreName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chUseMachineKeyStore);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerateNewKeys);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmRsaDemo";
            this.Text = "RSA Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

