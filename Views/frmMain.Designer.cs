namespace TORA_Affiliation.Views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.processRunningLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sendTestEmailBtn = new System.Windows.Forms.Button();
            this.testSqlConnBtn = new System.Windows.Forms.Button();
            this.RunManuallyBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // processRunningLbl
            // 
            this.processRunningLbl.AutoSize = true;
            this.processRunningLbl.Location = new System.Drawing.Point(55, 379);
            this.processRunningLbl.Name = "processRunningLbl";
            this.processRunningLbl.Size = new System.Drawing.Size(0, 13);
            this.processRunningLbl.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // sendTestEmailBtn
            // 
            this.sendTestEmailBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sendTestEmailBtn.Location = new System.Drawing.Point(318, 431);
            this.sendTestEmailBtn.Name = "sendTestEmailBtn";
            this.sendTestEmailBtn.Size = new System.Drawing.Size(251, 48);
            this.sendTestEmailBtn.TabIndex = 7;
            this.sendTestEmailBtn.Text = "Send Test Email";
            this.sendTestEmailBtn.UseVisualStyleBackColor = true;
            this.sendTestEmailBtn.Click += new System.EventHandler(this.sendTestEmailBtn_Click);
            // 
            // testSqlConnBtn
            // 
            this.testSqlConnBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.testSqlConnBtn.Location = new System.Drawing.Point(318, 495);
            this.testSqlConnBtn.Name = "testSqlConnBtn";
            this.testSqlConnBtn.Size = new System.Drawing.Size(251, 48);
            this.testSqlConnBtn.TabIndex = 9;
            this.testSqlConnBtn.Text = "Test SQL Connection";
            this.testSqlConnBtn.UseVisualStyleBackColor = true;
            this.testSqlConnBtn.Click += new System.EventHandler(this.testSqlConnBtn_Click);
            // 
            // RunManuallyBtn
            // 
            this.RunManuallyBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RunManuallyBtn.Location = new System.Drawing.Point(22, 494);
            this.RunManuallyBtn.Name = "RunManuallyBtn";
            this.RunManuallyBtn.Size = new System.Drawing.Size(251, 48);
            this.RunManuallyBtn.TabIndex = 10;
            this.RunManuallyBtn.Text = "Run Manually";
            this.RunManuallyBtn.UseVisualStyleBackColor = true;
            this.RunManuallyBtn.Click += new System.EventHandler(this.RunManuallyBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SettingsBtn.Location = new System.Drawing.Point(22, 431);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(251, 48);
            this.SettingsBtn.TabIndex = 8;
            this.SettingsBtn.Text = "Parameters";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 557);
            this.Controls.Add(this.processRunningLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendTestEmailBtn);
            this.Controls.Add(this.testSqlConnBtn);
            this.Controls.Add(this.RunManuallyBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPAP Affiliations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processRunningLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sendTestEmailBtn;
        private System.Windows.Forms.Button testSqlConnBtn;
        private System.Windows.Forms.Button RunManuallyBtn;
        private System.Windows.Forms.Button SettingsBtn;
    }
}