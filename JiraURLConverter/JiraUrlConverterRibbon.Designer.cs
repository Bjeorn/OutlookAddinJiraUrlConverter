namespace JiraURLConverter
{
    partial class jordbruksverketRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public jordbruksverketRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jordbruksverket = this.Factory.CreateRibbonTab();
            this.JiraUrl = this.Factory.CreateRibbonGroup();
            this.onIncoming = this.Factory.CreateRibbonToggleButton();
            this.onOutgoing = this.Factory.CreateRibbonToggleButton();
            this.btnPrefixesDialog = this.Factory.CreateRibbonButton();
            this.Jordbruksverket.SuspendLayout();
            this.JiraUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Jordbruksverket
            // 
            this.Jordbruksverket.Groups.Add(this.JiraUrl);
            this.Jordbruksverket.Label = "Jordbruksverket";
            this.Jordbruksverket.Name = "Jordbruksverket";
            // 
            // JiraUrl
            // 
            this.JiraUrl.Items.Add(this.onIncoming);
            this.JiraUrl.Items.Add(this.onOutgoing);
            this.JiraUrl.Items.Add(this.btnPrefixesDialog);
            this.JiraUrl.Label = "Jira Url";
            this.JiraUrl.Name = "JiraUrl";
            // 
            // onIncoming
            // 
            this.onIncoming.Label = "Formatera ingående mail";
            this.onIncoming.Name = "onIncoming";
            this.onIncoming.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.onIncoming_Click);
            // 
            // onOutgoing
            // 
            this.onOutgoing.Label = "Formatera utgående mail";
            this.onOutgoing.Name = "onOutgoing";
            this.onOutgoing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.onOutgoing_Click);
            // 
            // btnPrefixesDialog
            // 
            this.btnPrefixesDialog.Label = "Lägg till/ta bort prefix";
            this.btnPrefixesDialog.Name = "btnPrefixesDialog";
            this.btnPrefixesDialog.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPrefixesDialog_Click);
            // 
            // jordbruksverketRibbon
            // 
            this.Name = "jordbruksverketRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.Jordbruksverket);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.JiraUrlConverterRibbon_Load);
            this.Jordbruksverket.ResumeLayout(false);
            this.Jordbruksverket.PerformLayout();
            this.JiraUrl.ResumeLayout(false);
            this.JiraUrl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Office.Tools.Ribbon.RibbonTab Jordbruksverket;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup JiraUrl;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton onIncoming;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton onOutgoing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPrefixesDialog;
    }

    partial class ThisRibbonCollection
    {
        internal jordbruksverketRibbon JiraUrlConverterRibbon
        {
            get { return this.GetRibbon<jordbruksverketRibbon>(); }
        }
    }
}
