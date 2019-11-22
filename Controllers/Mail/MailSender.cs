using System.Collections.Generic;
using TORA_Affiliation.Controllers.Log;
using TORA_Affiliation.Interfaces;

namespace TORA_Affiliation.Controllers.Mail
{
    class MailSender
    {
        private ILogger _logger;

        public MailSender()
        {
            _logger = new TraceLogger();
        }

        public void SendErrorMail(string strSboErrorMessage)
        {
            var mailer = new Mailer();
            var mailCreator = new ErrorMailBuilder();

            _logger.Error(strSboErrorMessage);

            var body = mailCreator.GetMailBody(strSboErrorMessage);
            mailer.SendMail($"Affiliation Error Mail", body, true);

            _logger.Info("Error E-mail Sent");
        }

        /// <summary>
        /// Send an email with confirmation message 
        /// </summary>
        public void SendConfirmMail(string message)
        {
            var mailer = new Mailer();
            var mailCreator = new ConfirmMailBuilder();

            var body = mailCreator.GetMailBody(message);
            mailer.SendMail($"Affiliation Service Confirmation", body, true);

            _logger.Info("Confirmation E-mail Sent");
        }
    }
}
