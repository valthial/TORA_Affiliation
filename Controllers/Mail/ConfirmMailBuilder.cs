using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Web.UI.WebControls;

namespace TORA_Affiliation.Controllers.Mail
{
    class ConfirmMailBuilder
    {
        public string GetMailBody(string sendMessage)
        {
            string mailTemplate;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "TORA_Affiliation.Resources.ConfirmMailTemplate.html";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                mailTemplate = reader.ReadToEnd();
            }

            MailDefinition md = new MailDefinition();
            md.From = Config.ReadConfig().EmailAddressFrom;
            md.IsBodyHtml = true;


            string htmlConfirmations = string.Empty;

            htmlConfirmations +=
                $"<h3 style='text - align:left; font - family:Helvetica,Arial,sans - serif; font - size:15px; margin - bottom:0; color:#5F5F5F;line-height:135%'>{sendMessage}</h3>";
            htmlConfirmations += "<div><br /></div>";


            var replacements = new ListDictionary();
            replacements.Add("{confirmations}", htmlConfirmations);
            var now = DateTime.Now;
            replacements.Add("{Date}", now.ToString("G"));

            var message = md.CreateMailMessage(Config.ReadConfig().EmailTo, replacements, mailTemplate, new System.Web.UI.Control());
            return message.Body;
        }
    }
}
