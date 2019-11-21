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
        /// <param name="je"></param>
        /// <param name="sapb1ErrorMsg"></param>
        /// <param name="AffiliationErrorMessage"></param>
        /// <returns></returns>

        //TODO - Error Mail Body

        //public string GetMailBody(string sapb1ErrorMsg, string AffiliationErrorMessage)
        //{
        //    //Get e-mail Template
        //    string mailTemplate;
        //    var assembly = Assembly.GetExecutingAssembly();
        //    var resourceName = "TORA_Affiliation.Resources.ErrorMailTemplate.html";

        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    using (StreamReader reader = new StreamReader(stream))
        //    {
        //        mailTemplate = reader.ReadToEnd();
        //    }

        //    MailDefinition md = new MailDefinition();
        //    md.From = Config.ReadConfig().EmailAddressFrom;
        //    md.IsBodyHtml = true;


        //    var message = md.CreateMailMessage(Config.ReadConfig().EmailTo, mailTemplate, new System.Web.UI.Control());

        //    return message.Body;
        //}
    }
}
