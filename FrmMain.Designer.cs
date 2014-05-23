namespace WiFiProfiles
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDnsServer2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDnsServer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefaultGateway = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoIPStatis = new System.Windows.Forms.RadioButton();
            this.rdoIPDinamis = new System.Windows.Forms.RadioButton();
            this.cmbNetworkConnection = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(187, 267);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDnsServer2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDnsServer1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDefaultGateway);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSubnetMask);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(6, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtDnsServer2
            // 
            this.txtDnsServer2.Location = new System.Drawing.Point(95, 134);
            this.txtDnsServer2.Name = "txtDnsServer2";
            this.txtDnsServer2.Size = new System.Drawing.Size(150, 20);
            this.txtDnsServer2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DNS Server 2";
            // 
            // txtDnsServer1
            // 
            this.txtDnsServer1.Location = new System.Drawing.Point(95, 106);
            this.txtDnsServer1.Name = "txtDnsServer1";
            this.txtDnsServer1.Size = new System.Drawing.Size(150, 20);
            this.txtDnsServer1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNS Server 1";
            // 
            // txtDefaultGateway
            // 
            this.txtDefaultGateway.Location = new System.Drawing.Point(95, 78);
            this.txtDefaultGateway.Name = "txtDefaultGateway";
            this.txtDefaultGateway.Size = new System.Drawing.Size(150, 20);
            this.txtDefaultGateway.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Default gateway";
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(95, 50);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(150, 20);
            this.txtSubnetMask.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet mask";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(95, 22);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(150, 20);
            this.txtIPAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            // 
            // rdoIPStatis
            // 
            this.rdoIPStatis.AutoSize = true;
            this.rdoIPStatis.Location = new System.Drawing.Point(12, 94);
            this.rdoIPStatis.Name = "rdoIPStatis";
            this.rdoIPStatis.Size = new System.Drawing.Size(64, 17);
            this.rdoIPStatis.TabIndex = 0;
            this.rdoIPStatis.Text = "IP Statis";
            this.rdoIPStatis.UseVisualStyleBackColor = true;
            this.rdoIPStatis.CheckedChanged += new System.EventHandler(this.rdoIPStatis_CheckedChanged);
            // 
            // rdoIPDinamis
            // 
            this.rdoIPDinamis.AutoSize = true;
            this.rdoIPDinamis.Checked = true;
            this.rdoIPDinamis.Location = new System.Drawing.Point(12, 69);
            this.rdoIPDinamis.Name = "rdoIPDinamis";
            this.rdoIPDinamis.Size = new System.Drawing.Size(75, 17);
            this.rdoIPDinamis.TabIndex = 0;
            this.rdoIPDinamis.TabStop = true;
            this.rdoIPDinamis.Text = "IP Dinamis";
            this.rdoIPDinamis.UseVisualStyleBackColor = true;
            this.rdoIPDinamis.CheckedChanged += new System.EventHandler(this.rdoIPDinamis_CheckedChanged);
            // 
            // cmbNetworkConnection
            // 
            this.cmbNetworkConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetworkConnection.FormattingEnabled = true;
            this.cmbNetworkConnection.Location = new System.Drawing.Point(6, 19);
            this.cmbNetworkConnection.Name = "cmbNetworkConnection";
            this.cmbNetworkConnection.Size = new System.Drawing.Size(244, 21);
            this.cmbNetworkConnection.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNetworkConnection);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network Connection";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rdoIPStatis);
            this.Controls.Add(this.rdoIPDinamis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wi-Fi Profiles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoIPStatis;
        private System.Windows.Forms.TextBox txtDnsServer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDnsServer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDefaultGateway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoIPDinamis;
        private System.Windows.Forms.ComboBox cmbNetworkConnection;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

