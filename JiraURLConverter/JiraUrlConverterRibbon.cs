using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Collections.Specialized;

namespace JiraURLConverter
{
    public partial class jordbruksverketRibbon
    {
        private void JiraUrlConverterRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            SetSettings();
        }

        private void SetSettings()
        {
            onIncoming.Checked = Properties.Settings.Default.JiraURLConverterOnIncoming;
            onOutgoing.Checked = Properties.Settings.Default.JiraURLConverterOnOutgoing;
        }

        private void btnPrefixesDialog_Click(object sender, RibbonControlEventArgs e)
        {
            PrefixesForm prefixesForm = new PrefixesForm();
            prefixesForm.Show();
        }

        private void onOutgoing_Click(object sender, RibbonControlEventArgs e)
        {
            saveSettingOnOutgoing(onOutgoing.Checked);
        }

        private void onIncoming_Click(object sender, RibbonControlEventArgs e)
        {
            saveSettingOnIncoming(onIncoming.Checked);
        }

        /// <summary>
        /// Saves setting for incoming mails.
        /// </summary>
        /// <param name="value"></param>
        public void saveSettingOnIncoming(bool value)
        {
            Properties.Settings.Default.JiraURLConverterOnIncoming = value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Saves setting for mails being sent.
        /// </summary>
        /// <param name="value"></param>
        public void saveSettingOnOutgoing(bool value)
        {
            Properties.Settings.Default.JiraURLConverterOnOutgoing = value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Saves prefixes.
        /// </summary>
        /// <param name="collection"></param>
        public void saveSettingPrefixes(StringCollection collection)
        {
            Properties.Settings.Default.JiraURLConverterPrefixes = collection;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Resets the Url to the default one.
        /// </summary>
        public void resetUrlToDefault()
        {
            Properties.Settings.Default.JiraURLConverterURL = Properties.Settings.Default.JiraURLConverterURLDefault;
            Properties.Settings.Default.Save();
        }
    }
}
