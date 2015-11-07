using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraURLConverter
{
    public partial class PrefixesForm : Form
    {
        public PrefixesForm()
        {
            InitializeComponent();
            InitList();
        }

        private void InitList()
        {
            foreach (string prefix in Properties.Settings.Default.JiraURLConverterPrefixes)
            {
                listPrefixes.Items.Add(prefix);
            }
        }

        private void addPrefix_Click(object sender, EventArgs e)
        {
            addPrefixToList();
        }

        private void addPrefixToList()
        {
            btnSave.Enabled = true;
            if (txtNewPrefix.Text.Trim().Length > 0)
            {
                listPrefixes.Items.Add(txtNewPrefix.Text.Trim());
                txtNewPrefix.Text = "";
            }
        }

        private void btnRemovePrefix_Click(object sender, EventArgs e)
        {
            if (listPrefixes.SelectedItems.Count < 1)
                return;
            btnSave.Enabled = true;
            foreach (ListViewItem item in listPrefixes.SelectedItems)
            {
                listPrefixes.Items.Remove(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringCollection stringCollection = new StringCollection();
            foreach (ListViewItem item in listPrefixes.Items)
            {
                stringCollection.Add(item.Text);
            }

            Properties.Settings.Default.JiraURLConverterPrefixes = stringCollection;
            Properties.Settings.Default.Save();

            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            Close();
            Dispose();
        }

        private void txtNewPrefix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Return)
            {
                addPrefixToList();
            }
        }
    }
}
