using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORA_Affiliation.Controllers;
using TORA_Affiliation.Models;

namespace TORA_Affiliation.Views
{
    //TODO - handle comments
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            LoadSettingValues();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            var config = new ConfigModel();


            //SQl Credentials
            //--------------
            config.SQLServerName = sqlServerNameTxt.Text;
            config.SQLDatabaseName = sqlDatabaseNameTxt.Text;
            config.SQLUsername = sqlUsernameTxt.Text;
            config.SQLPassword = Crypto.ToSecureString(sqlPasswordTxt.Text);

            ////SAP B1 Credentials
            ////------------------
            //config.SboServerName = sboServerNameTxt.Text;
            //config.SboDatabaseName = sboDbNameTxt.Text;
            //config.SboDatabaseUsername = sboDbUsernameTxt.Text;
            //config.SboDatabasePassword = Crypto.ToSecureString(sboDbPasswordTxt.Text);
            //config.SboDatabaseType = sboDbTypeTxt.Text;
            //config.SboCompanyUsername = sboCompanyUsernameTxt.Text;
            //config.SboCompanyPassword = Crypto.ToSecureString(sboCompanyPasswordTxt.Text);
            //config.SboLicenseServer = sboLisenceServerTxt.Text;

            ////Item Codes
            ////----------
            //config.SboItemCodePayIn = itemCodePayInTxt.Text;
            //config.SboItemCodePayOut = itemCodePayOutTxt.Text;
            //config.SboItemCodeRefund = itemCodeRefundTxt.Text;

            //Email Credentials
            //-----------------
            config.SmtpClient = smtpClientTxt.Text;
            config.EmailPort = emailPortTxt.Text;
            config.EmailAddressFrom = emailAddressFromTxt.Text;
            config.EmailUsername = emailUsernameTxt.Text;
            config.EmailPassword = Crypto.ToSecureString(emailPasswordTxt.Text);
            config.EmailSignature = emailSignatureTxt.Text;
            config.EmailTo = emailToTxt.Text;
            config.EmailCC = emailCCTxt.Text;

            Config.SaveConfig(config);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restoreToDefaultBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Reset Settings to Default?", "Reset to Default Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Config.CreateConfig();
                LoadSettingValues();
            }
        }

        private void LoadSettingValues()
        {
            var config = Config.ReadConfig();

            if (config == null)
            {
                Config.CreateConfig();
            }
            //SQL Credentials
            //---------------
            sqlServerNameTxt.Text = config.SQLServerName;
            sqlDatabaseNameTxt.Text = config.SQLDatabaseName;
            sqlUsernameTxt.Text = config.SQLUsername;
            sqlPasswordTxt.Text = Config.PasswordDefaultText;

            ////SAP B1 Credentials
            ////------------------
            //sboServerNameTxt.Text = config.SboServerName;
            //sboDbNameTxt.Text = config.SboDatabaseName;
            //sboDbUsernameTxt.Text = config.SboDatabaseUsername;
            //sboDbPasswordTxt.Text = Config.PasswordDefaultText;
            //sboDbTypeTxt.Text = config.SboDatabaseType;
            //sboCompanyUsernameTxt.Text = config.SboCompanyUsername;
            //sboCompanyPasswordTxt.Text = Config.PasswordDefaultText;
            //sboLisenceServerTxt.Text = config.SboLicenseServer;

            ////Item Codes
            ////----------
            //itemCodePayInTxt.Text = config.SboItemCodePayIn;
            //itemCodePayOutTxt.Text = config.SboItemCodePayOut;
            //itemCodeRefundTxt.Text = config.SboItemCodeRefund;

            //Email Credentials
            //-----------------
            smtpClientTxt.Text = config.SmtpClient;
            emailPortTxt.Text = config.EmailPort;
            emailAddressFromTxt.Text = config.EmailAddressFrom;
            emailUsernameTxt.Text = config.EmailUsername;
            emailPasswordTxt.Text = Config.PasswordDefaultText;
            emailSignatureTxt.Text = config.EmailSignature;
            emailToTxt.Text = config.EmailTo;
            emailCCTxt.Text = config.EmailCC;


        }
    }
}
