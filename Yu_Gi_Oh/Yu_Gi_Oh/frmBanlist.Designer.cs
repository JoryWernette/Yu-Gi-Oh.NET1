namespace Yu_Gi_Oh
{
    partial class frmBanlist
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
            this.lblYGO = new System.Windows.Forms.Label();
            this.lstBanlist = new System.Windows.Forms.ListView();
            this.colCardType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdvancedFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTraditionalFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblYGO
            // 
            this.lblYGO.AutoSize = true;
            this.lblYGO.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYGO.Location = new System.Drawing.Point(12, 10);
            this.lblYGO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYGO.Name = "lblYGO";
            this.lblYGO.Size = new System.Drawing.Size(586, 170);
            this.lblYGO.TabIndex = 2;
            this.lblYGO.Text = "Yu-Gi-Oh!";
            // 
            // lstBanlist
            // 
            this.lstBanlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCardType,
            this.colCardName,
            this.colAdvancedFormat,
            this.colTraditionalFormat,
            this.colRemarks});
            this.lstBanlist.FullRowSelect = true;
            this.lstBanlist.GridLines = true;
            this.lstBanlist.HideSelection = false;
            this.lstBanlist.Location = new System.Drawing.Point(190, 223);
            this.lstBanlist.Name = "lstBanlist";
            this.lstBanlist.Size = new System.Drawing.Size(855, 745);
            this.lstBanlist.TabIndex = 3;
            this.lstBanlist.UseCompatibleStateImageBehavior = false;
            this.lstBanlist.View = System.Windows.Forms.View.Details;
            // 
            // colCardType
            // 
            this.colCardType.Text = "Card Type";
            this.colCardType.Width = 150;
            // 
            // colCardName
            // 
            this.colCardName.Text = "Card Name";
            this.colCardName.Width = 150;
            // 
            // colAdvancedFormat
            // 
            this.colAdvancedFormat.Text = "Advanced Format";
            this.colAdvancedFormat.Width = 200;
            // 
            // colTraditionalFormat
            // 
            this.colTraditionalFormat.Text = "Traditional Format";
            this.colTraditionalFormat.Width = 200;
            // 
            // colRemarks
            // 
            this.colRemarks.Text = "Remarks";
            this.colRemarks.Width = 150;
            // 
            // frmBanlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1634, 1029);
            this.Controls.Add(this.lstBanlist);
            this.Controls.Add(this.lblYGO);
            this.Name = "frmBanlist";
            this.Text = "Yu-Gi-Oh! - Banlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYGO;
        private System.Windows.Forms.ListView lstBanlist;
        private System.Windows.Forms.ColumnHeader colCardType;
        private System.Windows.Forms.ColumnHeader colCardName;
        private System.Windows.Forms.ColumnHeader colAdvancedFormat;
        private System.Windows.Forms.ColumnHeader colTraditionalFormat;
        private System.Windows.Forms.ColumnHeader colRemarks;
    }
}