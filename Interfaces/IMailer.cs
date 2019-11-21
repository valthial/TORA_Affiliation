using System.Collections.Generic;
using System.Net.Mail;

namespace TORA_Affiliation.Interfaces
{
    interface IMailer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="isBodyHtml"></param>
        /// <param name="attachments"></param>
        void SendMail(string subject, string body, bool isBodyHtml = false, List<Attachment> attachments = null);
    }
}
