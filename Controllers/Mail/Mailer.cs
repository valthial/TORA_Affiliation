using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TORA_Affiliation.Controllers.Log;
using TORA_Affiliation.Interfaces;

namespace TORA_Affiliation.Controllers.Mail
{
    class Mailer : IMailer
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly SmtpClient _smtpServer;

        /// <summary>
        /// 
        /// </summary>
        private readonly string _addressFrom;

        /// <summary>
        /// 
        /// </summary>
        private readonly string _emailCc;

        /// <summary>
        /// 
        /// </summary>
        private readonly string _addressTo;

        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// This class default constructor.
        /// Initialize the values of all necessary parameters.
        /// </summary>
        public Mailer()
        {
            var config = Config.ReadConfig();
            _logger = new TraceLogger();
            var smtpClient = config.SmtpClient;
            var emailPort = config.EmailPort;
            var emailUsername = config.EmailUsername;
            var password = config.EmailPassword;

            _addressFrom = config.EmailAddressFrom;
            _emailCc = config.EmailCC;
            _addressTo = config.EmailTo;
            try
            {
                _smtpServer = new SmtpClient(smtpClient)
                {
                    Port = Convert.ToInt32(emailPort),
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailUsername, password),
                };
            }
            catch (Exception e)
            {
                _logger.Error(e.Message, e);
            }



        }

        /// <summary>
        /// Send an email using the SMTP service.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="isBodyHtml"></param>
        /// <param name="attachments"></param>
        public void SendMail(string subject,
                              string body,
                              bool isBodyHtml = false,
                              List<Attachment> attachments = null)
        {
            var mailMessage = new MailMessage();

            try
            {
                var ccList = _emailCc.Split(',');
                var addressTo = _addressTo.Split(',');

                mailMessage.From = new MailAddress(_addressFrom);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = isBodyHtml;


                foreach (string to in addressTo)
                {
                    mailMessage.To.Add(new MailAddress(to));
                }

                foreach (string cc in ccList)
                {
                    if (string.IsNullOrEmpty(cc)) continue;
                    mailMessage.CC.Add(cc);
                }

                if (attachments != null)
                {

                    foreach (Attachment atc in attachments)
                    {
                        mailMessage.Attachments.Add(atc);
                    }

                }

                _smtpServer.Send(mailMessage);

            }
            catch (SmtpFailedRecipientException ex)
            {
                _logger.Error(ex.Message, ex);
            }
            finally
            {
                mailMessage.Dispose();
            }

        }
    }
}
