using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TORA_Affiliation.Models;

namespace TORA_Affiliation.Controllers
{
    class Config
    {
        /// <summary>
        /// Used to load a default text into text boxes so that the actual password is not loaded
        /// </summary>
        public const string PasswordDefaultText = "********";

        /// <summary>
        /// Reads the configuration file (Config\MainConf.xml) and returns a ConfigModel Object
        /// </summary>
        /// <returns></returns>
        public static ConfigModel ReadConfig()
        {
            // IMPORTANT: this function is used throughout this application, so . . .
            //            to let it also be usable from the command line
            //            no UI interactions should be allowed

            var filePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (!File.Exists(Path.Combine(filePath, @"Config\MainConf.xml")))
            {
                CreateConfig();

            }

            var xdoc = XDocument.Load(Path.Combine(filePath, @"Config\MainConf.xml"));
            var config = from r in xdoc.Descendants("config")
                         select new ConfigModel
                         {
                             // CMS database credentials
                             SQLServerName = r.Element("SQLServerName")?.Value,
                             SQLDatabaseName = r.Element("SQLDatabaseName")?.Value,
                             SQLUsername = r.Element("SQLUsername")?.Value,
                             SQLPassword = Crypto.DecryptString(r.Element("SQLPassword")?.Value),

                             // Email Credentials and configurations
                             SmtpClient = r.Element("emailSmtpClient")?.Value,
                             EmailPort = r.Element("emailPort")?.Value,
                             EmailAddressFrom = r.Element("emailAddress")?.Value,
                             EmailUsername = r.Element("emailUserName")?.Value,
                             EmailPassword = Crypto.DecryptString(r.Element("emailPassword")?.Value),
                             EmailSignature = r.Element("emailSignature")?.Value,
                             EmailTo = r.Element("emailTo")?.Value,
                             EmailCC = r.Element("emailCC")?.Value,
                         };

            return config.FirstOrDefault();
        }

        /// <summary>
        /// Saves the ConfigModel Object to Config\MainConf.xml
        /// </summary>
        /// <param name="config"></param>
        public static void SaveConfig(ConfigModel config)
        {
            var exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (null == exePath)
            {
                System.Windows.Forms.MessageBox.Show("Error - Invalid path for configuration file!");
                return;
            }

            var xdoc = XDocument.Load(Path.Combine(exePath, @"Config\MainConf.xml"));
            var root = xdoc.Element("config");

            if (null == root)
            {
                System.Windows.Forms.MessageBox.Show("Error - Invalid path for configuration file!");
                return;
            }

            // CMS SQL Credentials
            //---------------------
            // Server Name
            var elementDataSource = root.Element("SQLServerName");
            if (elementDataSource != null) elementDataSource.Value = config.SQLServerName;
            // Database Name
            var elementInitialCatalog = root.Element("SQLDatabaseName");
            if (elementInitialCatalog != null) elementInitialCatalog.Value = config.SQLDatabaseName;
            // User name
            var elementUserId = root.Element("SQLUsername");
            if (elementUserId != null) elementUserId.Value = config.SQLUsername;
            // Password
            var elementPassword = root.Element("SQLPassword");
            if (elementPassword != null &&
                config.SQLPassword != null &&
                Crypto.ToInsecureString(config.SQLPassword) != PasswordDefaultText)
            {
                elementPassword.Value = Crypto.EncryptString(config.SQLPassword);
            }

            // Email Credentials
            //-------------------
            // SMTP Client
            var elementEmailSmtpClient = root.Element("emailSmtpClient");
            if (elementEmailSmtpClient != null) elementEmailSmtpClient.Value = config.SmtpClient;
            // Port
            var elementEmailPort = root.Element("emailPort");
            if (elementEmailPort != null) elementEmailPort.Value = config.EmailPort;
            // Address From
            var elementEmaiAddressFrom = root.Element("emailAddress");
            if (elementEmaiAddressFrom != null) elementEmaiAddressFrom.Value = config.EmailAddressFrom;
            // User name
            var elementEmailUserName = root.Element("emailUserName");
            if (elementEmailUserName != null) elementEmailUserName.Value = config.EmailUsername;
            // Password
            var elementEmailPassword = root.Element("emailPassword");
            if (elementEmailPassword != null && config.EmailPassword != null && Crypto.ToInsecureString(config.EmailPassword) != PasswordDefaultText)
            {
                elementEmailPassword.Value = Crypto.EncryptString(config.EmailPassword);
            }

            // Signature
            var elementEmailSignature = root.Element("emailSignature");
            if (elementEmailSignature != null) elementEmailSignature.Value = config.EmailSignature;
            // Stakeholders
            var elementEmailStakeholders = root.Element("emailTo");
            if (elementEmailStakeholders != null) elementEmailStakeholders.Value = config.EmailTo;
            // Email CC
            var elementEmailCc = root.Element("emailCC");
            if (elementEmailCc != null) elementEmailCc.Value = config.EmailCC;

            xdoc.Save(Path.Combine(exePath, @"Config\MainConf.xml"));
        }



        /// <summary>
        /// 
        /// </summary>
        public static ConfigModel CreateConfig()
        {
            var filePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (filePath == null)
            {
                System.Windows.Forms.MessageBox.Show("Error: Invalid Path for Configuration File", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
            Directory.CreateDirectory(Path.Combine(filePath, @"Config"));

            XDocument docXml = new XDocument(new XElement("config",

                new XComment("CMS SQL Configuration"),

                new XElement("SQLServerName", " "),
                new XElement("SQLDatabaseName", " "),
                new XElement("SQLUsername", " "),
                new XElement("SQLPassword", "AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAdnMEoBtcSU+FItXlzfD99wAAAAACAAAAAAAQZgAAAAEAACAAAAA+Fl+ujCeERQjind7zxKJ0k1mTufwlkF/j8AOOw/rPzwAAAAAOgAAAAAIAACAAAADUgU3XXTlEU7891G83P8piBXRWIzSM4vA1x9QtfP5hHiAAAAB9rOOC0UxgSug3uODI7RKLVg76jFC6fSjc3bwnd/4DrUAAAAC7LD5xJ50s4uM2l6MF7VyJj7EaezoIZ7X/7wynge+3X/ZivVMZm76DVF0vrAAeMbTlUGT2zqOypW6kjyFnFnZJ"),

                new XComment("SBO Configuration"),
              
                new XElement("SapB1DbUsername", " "),
          

                new XComment("Email Configuration"),

                new XElement("emailSmtpClient", " "),
                new XElement("emailPort", " "),
                new XElement("emailAddress", " "),
                new XElement("emailUserName", " "),
                new XElement("emailPassword", "AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAdnMEoBtcSU+FItXlzfD99wAAAAACAAAAAAAQZgAAAAEAACAAAAA+Fl+ujCeERQjind7zxKJ0k1mTufwlkF/j8AOOw/rPzwAAAAAOgAAAAAIAACAAAADUgU3XXTlEU7891G83P8piBXRWIzSM4vA1x9QtfP5hHiAAAAB9rOOC0UxgSug3uODI7RKLVg76jFC6fSjc3bwnd/4DrUAAAAC7LD5xJ50s4uM2l6MF7VyJj7EaezoIZ7X/7wynge+3X/ZivVMZm76DVF0vrAAeMbTlUGT2zqOypW6kjyFnFnZJ"),
                new XElement("emailSignature", " "),
                new XElement("emailTo", " "),
                new XElement("emailCC", "")));
            docXml.Save(Path.Combine(filePath, @"Config\MainConf.xml"));

            return null;
        }
    }
}
