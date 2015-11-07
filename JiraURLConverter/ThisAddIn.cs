using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Text.RegularExpressions;
using System.Collections.Specialized;

namespace JiraURLConverter
{
    public partial class ThisAddIn
    {
        private Outlook.Application application;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            application = Application.Application;
            application.NewMailEx += application_NewMailEx;
            application.ItemSend += Application_ItemSend;
        }
        
        /// <summary>
        /// Triggers when a mail is being sent.
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Cancel"></param>
        private void Application_ItemSend(object Item, ref bool Cancel)
        {
            Outlook.NameSpace olSession = Application.GetNamespace("MAPI");

            // Return if user has chosen to ignore this event
            if (!Properties.Settings.Default.JiraURLConverterOnOutgoing)
                return;

            if (Item is Outlook.MailItem)
            {
                convertTextToUrlInMail(Item as Outlook.MailItem);
            }
        }

        /// <summary>
        /// Triggers when a new mail arrives.
        /// </summary>
        /// <param name="EntryIDCollection"></param>
        private void application_NewMailEx(string EntryIDCollection)
        {
            Outlook.MailItem mail = null;
            Outlook.NameSpace olSession = Application.GetNamespace("MAPI");

            // Return if user has chosen to ignore this event
            if (!Properties.Settings.Default.JiraURLConverterOnIncoming)
                return;
            
            try
            {
                mail = olSession.GetItemFromID(EntryIDCollection);
            }
            catch (Exception)
            {
                return;
            }

            convertTextToUrlInMail(mail);
        }

        /// <summary>
        /// Converts matches from pattern to links.
        /// </summary>
        /// <param name="mail"></param>
        private void convertTextToUrlInMail(Outlook.MailItem mail)
        {
            string str = "";
            string url;
            Regex reg = null;
            StringBuilder pattern = new StringBuilder();

            pattern = CreateRegexPatternFromSettingsPrefixes();

            str = mail.HTMLBody;
            url = Properties.Settings.Default.JiraURLConverterURL ?? "";

            reg = new Regex(pattern.ToString(), RegexOptions.IgnoreCase);
            string qwerty = reg.Replace(str, "<a href='" + url + "'>$1</a>");

            mail.HTMLBody = qwerty;
            mail.Save();
        }

        /// <summary>
        /// Creates a pattern from the prefixes in the settings.
        /// </summary>
        /// <returns>pattern</returns>
        private StringBuilder CreateRegexPatternFromSettingsPrefixes()
        {
            StringBuilder pattern = new StringBuilder();
            pattern.Append("((");
            foreach (string prefix in Properties.Settings.Default.JiraURLConverterPrefixes)
            {
                pattern.Append("[" + prefix.Trim() + "]{" + prefix.Trim().Length + "}|");
            }
            pattern.Remove(pattern.Length - 1, 1);
            pattern.Append(")-[0-9]{1,5}(?![^<]*</a>))");

            return pattern;
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += new EventHandler(ThisAddIn_Startup);
            Shutdown += new EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
