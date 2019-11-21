using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TORA_Affiliation.Models
{
    class ConfigModel
    {
        //SQL Credentials
        //---------------

        /// <summary>
        /// The SQL Server Name.
        /// </summary>
        public string SQLServerName { get; set; }
        /// <summary>
        /// The SQL Database Name.
        /// </summary>
        public string SQLDatabaseName { get; set; }
        /// <summary>
        /// The Username for SQL Database.
        /// </summary>
        public string SQLUsername { get; set; }
        /// <summary>
        /// The Password for SQL Database.
        /// </summary>
        public SecureString SQLPassword { get; set; }

        //SAP Business One Credentials
        //----------------------------
        /// <summary>
        /// The SAP B1 Database Name.
        /// </summary>
        public string SboDatabaseName { get; set; }

        //ItemCodes for Affiliation (SBO - OITM.ItemCode)
        //------------------------
        /// <summary>
        /// The item code for Pay-In.
        /// </summary>
        public string SboItemCodePayIn { get; set; }
        /// <summary>
        /// The item code for Pay-Out.
        /// </summary>
        public string SboItemCodePayOut { get; set; }
        /// <summary>
        /// The item code for Refund.
        /// </summary>
        public string SboItemCodeRefund { get; set; }

        //Email Credentials
        /// <summary>
        /// The SMTP Client.
        /// </summary>
        public string SmtpClient { get; set; }
        /// <summary>
        /// The port for SMTP Client.
        /// </summary>
        public string EmailPort { get; set; }
        /// <summary>
        /// The Email use in From Section.
        /// </summary>
        public string EmailAddressFrom { get; set; }
        /// <summary>
        /// The Username for Email Service.
        /// </summary>
        public string EmailUsername { get; set; }
        /// <summary>
        /// The Password for Email Service.
        /// </summary>
        public SecureString EmailPassword { get; set; }
        /// <summary>
        /// The text qualifier to use as info for this group of emails.
        /// </summary>
        public string EmailSignature { get; set; }
        /// <summary>
        /// The Email use in To Address Section.
        /// </summary>
        public string EmailTo { get; set; }
        /// <summary>
        /// The Emails uses in CC Addresses Section.
        /// </summary>
        public string EmailCC { get; set; }

    }
}
