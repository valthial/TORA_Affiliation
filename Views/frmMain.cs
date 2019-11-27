using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TORA_Affiliation.Controllers;
using TORA_Affiliation.Controllers.Mail;

namespace TORA_Affiliation.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Views.frmConfig settings = new Views.frmConfig();
            settings.ShowDialog();
        }

        private void testSqlConnBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var config = Config.ReadConfig();
            var connectionsStr = $"Data Source = {config.SQLServerName}; "
                               + $"Initial Catalog = {config.SQLDatabaseName}; "
                               + $"User ID= {config.SQLUsername}; "
                               + $"Password= {Crypto.ToInsecureString(config.SQLPassword)}";

            using (var con = new SqlConnection(connectionsStr))
            {

                try
                {
                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        MessageBox.Show("SQL Connection OK"
                                       , "SQL Connection"
                                       , MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message
                                   , "SQL Connection"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void sendTestEmailBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            /*var mailer = new Mailer();
            mailer.SendMail("Affiliation Service Test Email"
                           , "Affiliation Service Test Email Body.");*/
            var mail = new MailSender();
            mail.SendConfirmMail("Test Mail Successfull");
            MessageBox.Show("Test Email sent");
            Cursor.Current = Cursors.Default;
        }

        private void RunManuallyBtn_Click(object sender, EventArgs e)
        {
            var creator = new MainCreator();
            Cursor.Current = Cursors.WaitCursor;

            if (creator.Create())
            {
                processRunningLbl.Text = "Done";
            }
            else
            {
                processRunningLbl.Text = "Failed";
            }
            Cursor.Current = Cursors.Default;
        }


    }
}
