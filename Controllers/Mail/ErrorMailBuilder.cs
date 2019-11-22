using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace TORA_Affiliation.Controllers.Mail
{
    class ErrorMailBuilder
    {
        /// <summary>
        /// Builds and returns the HTML of the Error Mail
        /// </summary>
        /// <param name="AffiliationErrorMessage"></param>
        /// <returns></returns>

        public string GetMailBody(string AffiliationErrorMessage)
        {
            //Get e-mail Template
            string mailTemplate;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "TORA_Affiliation.Resources.ErrorMailTemplate.html";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                mailTemplate = reader.ReadToEnd();
            }

            MailDefinition md = new MailDefinition();
            md.From = Config.ReadConfig().EmailAddressFrom;
            md.IsBodyHtml = true;


            var message = md.CreateMailMessage(Config.ReadConfig().EmailTo, null, mailTemplate, new System.Web.UI.Control());

            return message.Body;
        }
    }
}
