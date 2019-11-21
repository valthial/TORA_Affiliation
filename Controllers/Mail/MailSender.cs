using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //TODO - SendErrorMail function

        //public void SendErrorMail(SboJournalEntry journalEntry, string strSboErrorMessage)
        //{
        //    var mailer = new Mailer();
        //    var mailCreator = new ErrorMailBuilder();

        //    var eCommerceError = "none";

        //    if (string.IsNullOrEmpty(journalEntry.SboItem.ItemCode))
        //    {
        //        eCommerceError = $"Item missing for CMS Item {journalEntry.Transaction.ProductId}";
        //    }
        //    else if (journalEntry.DueDate == null)
        //    {
        //        eCommerceError = "DueDate is NULL. Please check the Due Days table [@TORA_REM_DUEDATES]";
        //    }
        //    /* else if (string.IsNullOrEmpty(journalEntry.SboItem.RetailBp) == true && journalEntry.Transaction.PaymentMethod == '2') 
        //     {
        //         eCommerceError = $"Transaction Type is Card but there is no Retail BP for Item {journalEntry.SboItem.ItemCode}";
        //     }*/

        //    _logger.Error(eCommerceError);

        //    var body = mailCreator.GetMailBody(journalEntry, strSboErrorMessage, eCommerceError);
        //    mailer.SendMail($"Cannot create Journal Entry for Transaction {journalEntry.Reference}", body, true);

        //    _logger.Info("Error E-mail Sent");
        //}

        ///// <summary>
        ///// Send an email with confirmation message about Journal Entries.
        ///// </summary>
        ///// <param name="confirmations"></param>
        //public void SendConfirmMail(IList<string> confirmations)
        //{
        //    var mailer = new Mailer();
        //    var mailCreator = new ConfirmMailBuilder();

        //    var body = mailCreator.GetMailBody(confirmations);
        //    mailer.SendMail($"E-Commerce Journal Entries Creations Service Confirmation", body, true);

        //    _logger.Info("Confirmation E-mail Sent");
        //}
    }
}
