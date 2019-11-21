namespace TORA_Affiliation.Views
{
    partial class frmConfig
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
            this.restoreToDefaultBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.EMAILTab = new System.Windows.Forms.TabPage();
            this.smtpClientTxt = new System.Windows.Forms.TextBox();
            this.emailPortTxt = new System.Windows.Forms.TextBox();
            this.emailAddressFromTxt = new System.Windows.Forms.TextBox();
            this.emailUsernameTxt = new System.Windows.Forms.TextBox();
            this.emailSignatureTxt = new System.Windows.Forms.TextBox();
            this.emailToTxt = new System.Windows.Forms.TextBox();
            this.emailCCTxt = new System.Windows.Forms.TextBox();
            this.emailPasswordTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.SQLTab = new System.Windows.Forms.TabPage();
            this.sapDatabaseNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlDatabaseNameTxt = new System.Windows.Forms.TextBox();
            this.sqlUsernameTxt = new System.Windows.Forms.TextBox();
            this.sqlServerNameTxt = new System.Windows.Forms.TextBox();
            this.sqlPasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EMAILTab.SuspendLayout();
            this.SQLTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restoreToDefaultBtn
            // 
            this.restoreToDefaultBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.restoreToDefaultBtn.Location = new System.Drawing.Point(600, 397);
            this.restoreToDefaultBtn.Name = "restoreToDefaultBtn";
            this.restoreToDefaultBtn.Size = new System.Drawing.Size(161, 40);
            this.restoreToDefaultBtn.TabIndex = 15;
            this.restoreToDefaultBtn.Text = "Restore to Default";
            this.restoreToDefaultBtn.UseVisualStyleBackColor = true;
            this.restoreToDefaultBtn.Click += new System.EventHandler(this.restoreToDefaultBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancelBtn.Location = new System.Drawing.Point(219, 400);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 37);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.applyBtn.Location = new System.Drawing.Point(38, 400);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(102, 37);
            this.applyBtn.TabIndex = 13;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // EMAILTab
            // 
            this.EMAILTab.Controls.Add(this.smtpClientTxt);
            this.EMAILTab.Controls.Add(this.emailPortTxt);
            this.EMAILTab.Controls.Add(this.emailAddressFromTxt);
            this.EMAILTab.Controls.Add(this.emailUsernameTxt);
            this.EMAILTab.Controls.Add(this.emailSignatureTxt);
            this.EMAILTab.Controls.Add(this.emailToTxt);
            this.EMAILTab.Controls.Add(this.emailCCTxt);
            this.EMAILTab.Controls.Add(this.emailPasswordTxt);
            this.EMAILTab.Controls.Add(this.label16);
            this.EMAILTab.Controls.Add(this.label17);
            this.EMAILTab.Controls.Add(this.label18);
            this.EMAILTab.Controls.Add(this.label19);
            this.EMAILTab.Controls.Add(this.label20);
            this.EMAILTab.Controls.Add(this.label21);
            this.EMAILTab.Controls.Add(this.label22);
            this.EMAILTab.Controls.Add(this.label23);
            this.EMAILTab.Location = new System.Drawing.Point(4, 22);
            this.EMAILTab.Name = "EMAILTab";
            this.EMAILTab.Size = new System.Drawing.Size(768, 330);
            this.EMAILTab.TabIndex = 3;
            this.EMAILTab.Text = "EMAIL";
            this.EMAILTab.UseVisualStyleBackColor = true;
            // 
            // smtpClientTxt
            // 
            this.smtpClientTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.smtpClientTxt.Location = new System.Drawing.Point(354, 17);
            this.smtpClientTxt.Name = "smtpClientTxt";
            this.smtpClientTxt.Size = new System.Drawing.Size(391, 26);
            this.smtpClientTxt.TabIndex = 1;
            // 
            // emailPortTxt
            // 
            this.emailPortTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailPortTxt.Location = new System.Drawing.Point(354, 49);
            this.emailPortTxt.Name = "emailPortTxt";
            this.emailPortTxt.Size = new System.Drawing.Size(391, 26);
            this.emailPortTxt.TabIndex = 2;
            // 
            // emailAddressFromTxt
            // 
            this.emailAddressFromTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailAddressFromTxt.Location = new System.Drawing.Point(354, 81);
            this.emailAddressFromTxt.Name = "emailAddressFromTxt";
            this.emailAddressFromTxt.Size = new System.Drawing.Size(391, 26);
            this.emailAddressFromTxt.TabIndex = 3;
            // 
            // emailUsernameTxt
            // 
            this.emailUsernameTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailUsernameTxt.Location = new System.Drawing.Point(354, 113);
            this.emailUsernameTxt.Name = "emailUsernameTxt";
            this.emailUsernameTxt.Size = new System.Drawing.Size(391, 26);
            this.emailUsernameTxt.TabIndex = 4;
            // 
            // emailSignatureTxt
            // 
            this.emailSignatureTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailSignatureTxt.Location = new System.Drawing.Point(354, 179);
            this.emailSignatureTxt.Name = "emailSignatureTxt";
            this.emailSignatureTxt.Size = new System.Drawing.Size(391, 26);
            this.emailSignatureTxt.TabIndex = 6;
            // 
            // emailToTxt
            // 
            this.emailToTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailToTxt.Location = new System.Drawing.Point(354, 211);
            this.emailToTxt.Name = "emailToTxt";
            this.emailToTxt.Size = new System.Drawing.Size(391, 26);
            this.emailToTxt.TabIndex = 7;
            // 
            // emailCCTxt
            // 
            this.emailCCTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailCCTxt.Location = new System.Drawing.Point(354, 243);
            this.emailCCTxt.Name = "emailCCTxt";
            this.emailCCTxt.Size = new System.Drawing.Size(391, 26);
            this.emailCCTxt.TabIndex = 8;
            // 
            // emailPasswordTxt
            // 
            this.emailPasswordTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailPasswordTxt.Location = new System.Drawing.Point(354, 145);
            this.emailPasswordTxt.Name = "emailPasswordTxt";
            this.emailPasswordTxt.Size = new System.Drawing.Size(391, 26);
            this.emailPasswordTxt.TabIndex = 5;
            this.emailPasswordTxt.UseSystemPasswordChar = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label16.Location = new System.Drawing.Point(18, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 23);
            this.label16.TabIndex = 25;
            this.label16.Text = "SMTP Client:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label17.Location = new System.Drawing.Point(18, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 23);
            this.label17.TabIndex = 24;
            this.label17.Text = "Email Port:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label18.Location = new System.Drawing.Point(18, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Address From:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label19.Location = new System.Drawing.Point(18, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 23);
            this.label19.TabIndex = 22;
            this.label19.Text = "Username:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label20.Location = new System.Drawing.Point(18, 144);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 23);
            this.label20.TabIndex = 21;
            this.label20.Text = "Password:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label21.Location = new System.Drawing.Point(18, 178);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 23);
            this.label21.TabIndex = 20;
            this.label21.Text = "Signature:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label22.Location = new System.Drawing.Point(18, 210);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(231, 23);
            this.label22.TabIndex = 19;
            this.label22.Text = "Email To (comma seperated):";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label23.Location = new System.Drawing.Point(18, 242);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(234, 23);
            this.label23.TabIndex = 18;
            this.label23.Text = "Email CC (comma seperated):";
            // 
            // SQLTab
            // 
            this.SQLTab.Controls.Add(this.sapDatabaseNameTxt);
            this.SQLTab.Controls.Add(this.label5);
            this.SQLTab.Controls.Add(this.sqlDatabaseNameTxt);
            this.SQLTab.Controls.Add(this.sqlUsernameTxt);
            this.SQLTab.Controls.Add(this.sqlServerNameTxt);
            this.SQLTab.Controls.Add(this.sqlPasswordTxt);
            this.SQLTab.Controls.Add(this.label4);
            this.SQLTab.Controls.Add(this.label3);
            this.SQLTab.Controls.Add(this.label2);
            this.SQLTab.Controls.Add(this.label1);
            this.SQLTab.Location = new System.Drawing.Point(4, 22);
            this.SQLTab.Name = "SQLTab";
            this.SQLTab.Padding = new System.Windows.Forms.Padding(3);
            this.SQLTab.Size = new System.Drawing.Size(768, 330);
            this.SQLTab.TabIndex = 0;
            this.SQLTab.Text = "SQL";
            this.SQLTab.UseVisualStyleBackColor = true;
            // 
            // sapDatabaseNameTxt
            // 
            this.sapDatabaseNameTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sapDatabaseNameTxt.Location = new System.Drawing.Point(359, 83);
            this.sapDatabaseNameTxt.Name = "sapDatabaseNameTxt";
            this.sapDatabaseNameTxt.Size = new System.Drawing.Size(391, 26);
            this.sapDatabaseNameTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(19, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "SAP Database Name:";
            // 
            // sqlDatabaseNameTxt
            // 
            this.sqlDatabaseNameTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sqlDatabaseNameTxt.Location = new System.Drawing.Point(359, 51);
            this.sqlDatabaseNameTxt.Name = "sqlDatabaseNameTxt";
            this.sqlDatabaseNameTxt.Size = new System.Drawing.Size(391, 26);
            this.sqlDatabaseNameTxt.TabIndex = 2;
            // 
            // sqlUsernameTxt
            // 
            this.sqlUsernameTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sqlUsernameTxt.Location = new System.Drawing.Point(359, 115);
            this.sqlUsernameTxt.Name = "sqlUsernameTxt";
            this.sqlUsernameTxt.Size = new System.Drawing.Size(391, 26);
            this.sqlUsernameTxt.TabIndex = 3;
            // 
            // sqlServerNameTxt
            // 
            this.sqlServerNameTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sqlServerNameTxt.Location = new System.Drawing.Point(359, 19);
            this.sqlServerNameTxt.Name = "sqlServerNameTxt";
            this.sqlServerNameTxt.Size = new System.Drawing.Size(391, 26);
            this.sqlServerNameTxt.TabIndex = 1;
            // 
            // sqlPasswordTxt
            // 
            this.sqlPasswordTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sqlPasswordTxt.Location = new System.Drawing.Point(359, 147);
            this.sqlPasswordTxt.Name = "sqlPasswordTxt";
            this.sqlPasswordTxt.Size = new System.Drawing.Size(391, 26);
            this.sqlPasswordTxt.TabIndex = 4;
            this.sqlPasswordTxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "CMS Database Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(19, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SQLTab);
            this.tabControl1.Controls.Add(this.EMAILTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 356);
            this.tabControl1.TabIndex = 12;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restoreToDefaultBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.EMAILTab.ResumeLayout(false);
            this.EMAILTab.PerformLayout();
            this.SQLTab.ResumeLayout(false);
            this.SQLTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restoreToDefaultBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.TabPage EMAILTab;
        private System.Windows.Forms.TextBox smtpClientTxt;
        private System.Windows.Forms.TextBox emailPortTxt;
        private System.Windows.Forms.TextBox emailAddressFromTxt;
        private System.Windows.Forms.TextBox emailUsernameTxt;
        private System.Windows.Forms.TextBox emailSignatureTxt;
        private System.Windows.Forms.TextBox emailToTxt;
        private System.Windows.Forms.TextBox emailCCTxt;
        private System.Windows.Forms.TextBox emailPasswordTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage SQLTab;
        private System.Windows.Forms.TextBox sapDatabaseNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sqlDatabaseNameTxt;
        private System.Windows.Forms.TextBox sqlUsernameTxt;
        private System.Windows.Forms.TextBox sqlServerNameTxt;
        private System.Windows.Forms.TextBox sqlPasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}