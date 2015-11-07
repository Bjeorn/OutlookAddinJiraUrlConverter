namespace JiraURLConverter
{
    partial class PrefixesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPrefixes = new System.Windows.Forms.ListView();
            this.addPrefix = new System.Windows.Forms.Button();
            this.btnRemovePrefix = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNewPrefix = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPrefixes
            // 
            this.listPrefixes.GridLines = true;
            this.listPrefixes.LabelWrap = false;
            this.listPrefixes.Location = new System.Drawing.Point(12, 12);
            this.listPrefixes.MultiSelect = false;
            this.listPrefixes.Name = "listPrefixes";
            this.listPrefixes.Size = new System.Drawing.Size(122, 237);
            this.listPrefixes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listPrefixes.TabIndex = 0;
            this.listPrefixes.UseCompatibleStateImageBehavior = false;
            this.listPrefixes.View = System.Windows.Forms.View.List;
            // 
            // addPrefix
            // 
            this.addPrefix.Location = new System.Drawing.Point(140, 39);
            this.addPrefix.Name = "addPrefix";
            this.addPrefix.Size = new System.Drawing.Size(132, 36);
            this.addPrefix.TabIndex = 1;
            this.addPrefix.Text = "Lägg till prefix";
            this.addPrefix.UseVisualStyleBackColor = true;
            this.addPrefix.Click += new System.EventHandler(this.addPrefix_Click);
            // 
            // btnRemovePrefix
            // 
            this.btnRemovePrefix.Location = new System.Drawing.Point(140, 81);
            this.btnRemovePrefix.Name = "btnRemovePrefix";
            this.btnRemovePrefix.Size = new System.Drawing.Size(132, 36);
            this.btnRemovePrefix.TabIndex = 1;
            this.btnRemovePrefix.Text = "Ta bort markerat prefix";
            this.btnRemovePrefix.UseVisualStyleBackColor = true;
            this.btnRemovePrefix.Click += new System.EventHandler(this.btnRemovePrefix_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(140, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNewPrefix
            // 
            this.txtNewPrefix.Location = new System.Drawing.Point(141, 13);
            this.txtNewPrefix.Name = "txtNewPrefix";
            this.txtNewPrefix.Size = new System.Drawing.Size(131, 20);
            this.txtNewPrefix.TabIndex = 2;
            this.txtNewPrefix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPrefix_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(140, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PrefixesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtNewPrefix);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemovePrefix);
            this.Controls.Add(this.addPrefix);
            this.Controls.Add(this.listPrefixes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrefixesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till/ta bort prefix";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPrefixes;
        private System.Windows.Forms.Button addPrefix;
        private System.Windows.Forms.Button btnRemovePrefix;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNewPrefix;
        private System.Windows.Forms.Button btnSave;
    }
}