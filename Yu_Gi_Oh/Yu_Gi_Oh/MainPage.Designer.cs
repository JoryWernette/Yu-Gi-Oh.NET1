namespace Yu_Gi_Oh
{
    partial class MainPage
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
            this.lstCard = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCard_category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCard_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonster_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSub_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLevel_rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAttack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDefense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBanlist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCard_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblYGO = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnDeckLists = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBanlist = new System.Windows.Forms.Button();
            this.lblClickSomething = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCard
            // 
            this.lstCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCard_category,
            this.colCard_type,
            this.colMonster_type,
            this.colSub_type,
            this.colAttribute,
            this.colLevel_rank,
            this.colAttack,
            this.colDefense,
            this.colBanlist,
            this.colCard_text});
            this.lstCard.FullRowSelect = true;
            this.lstCard.GridLines = true;
            this.lstCard.HideSelection = false;
            this.lstCard.Location = new System.Drawing.Point(0, 204);
            this.lstCard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstCard.MultiSelect = false;
            this.lstCard.Name = "lstCard";
            this.lstCard.Size = new System.Drawing.Size(2080, 446);
            this.lstCard.TabIndex = 0;
            this.lstCard.UseCompatibleStateImageBehavior = false;
            this.lstCard.View = System.Windows.Forms.View.Details;
            this.lstCard.DoubleClick += new System.EventHandler(this.lstCard_DoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 125;
            // 
            // colCard_category
            // 
            this.colCard_category.Text = "Category";
            // 
            // colCard_type
            // 
            this.colCard_type.Text = "Card Type";
            this.colCard_type.Width = 80;
            // 
            // colMonster_type
            // 
            this.colMonster_type.Text = "Monster Type";
            this.colMonster_type.Width = 80;
            // 
            // colSub_type
            // 
            this.colSub_type.Text = "Sub_type";
            this.colSub_type.Width = 70;
            // 
            // colAttribute
            // 
            this.colAttribute.Text = "Attribute";
            // 
            // colLevel_rank
            // 
            this.colLevel_rank.Text = "Level/Rank";
            this.colLevel_rank.Width = 70;
            // 
            // colAttack
            // 
            this.colAttack.Text = "Attack";
            // 
            // colDefense
            // 
            this.colDefense.Text = "Defense";
            // 
            // colBanlist
            // 
            this.colBanlist.Text = "Banlist";
            // 
            // colCard_text
            // 
            this.colCard_text.Text = "Card Text";
            this.colCard_text.Width = 320;
            // 
            // lblYGO
            // 
            this.lblYGO.AutoSize = true;
            this.lblYGO.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYGO.Location = new System.Drawing.Point(12, 10);
            this.lblYGO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYGO.Name = "lblYGO";
            this.lblYGO.Size = new System.Drawing.Size(586, 170);
            this.lblYGO.TabIndex = 1;
            this.lblYGO.Text = "Yu-Gi-Oh!";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(1878, 28);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(160, 131);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnDeckLists
            // 
            this.btnDeckLists.Location = new System.Drawing.Point(1712, 28);
            this.btnDeckLists.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeckLists.Name = "btnDeckLists";
            this.btnDeckLists.Size = new System.Drawing.Size(160, 131);
            this.btnDeckLists.TabIndex = 7;
            this.btnDeckLists.Text = "Deck Lists";
            this.btnDeckLists.UseVisualStyleBackColor = true;
            this.btnDeckLists.Click += new System.EventHandler(this.btnDeckLists_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1546, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 131);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search Cards";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBanlist
            // 
            this.btnBanlist.Location = new System.Drawing.Point(1380, 28);
            this.btnBanlist.Margin = new System.Windows.Forms.Padding(4);
            this.btnBanlist.Name = "btnBanlist";
            this.btnBanlist.Size = new System.Drawing.Size(160, 131);
            this.btnBanlist.TabIndex = 5;
            this.btnBanlist.Text = "Banlist";
            this.btnBanlist.UseVisualStyleBackColor = true;
            this.btnBanlist.Click += new System.EventHandler(this.btnBanlist_Click);
            // 
            // lblClickSomething
            // 
            this.lblClickSomething.AutoSize = true;
            this.lblClickSomething.Location = new System.Drawing.Point(36, 673);
            this.lblClickSomething.Name = "lblClickSomething";
            this.lblClickSomething.Size = new System.Drawing.Size(307, 25);
            this.lblClickSomething.TabIndex = 9;
            this.lblClickSomething.Text = "*Double Click a card for details";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2106, 815);
            this.Controls.Add(this.lblClickSomething);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnDeckLists);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBanlist);
            this.Controls.Add(this.lblYGO);
            this.Controls.Add(this.lstCard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPage";
            this.Text = "Yu-Gi-Oh!";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCard;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCard_category;
        private System.Windows.Forms.ColumnHeader colCard_type;
        private System.Windows.Forms.ColumnHeader colMonster_type;
        private System.Windows.Forms.ColumnHeader colSub_type;
        private System.Windows.Forms.ColumnHeader colAttribute;
        private System.Windows.Forms.ColumnHeader colLevel_rank;
        private System.Windows.Forms.ColumnHeader colAttack;
        private System.Windows.Forms.ColumnHeader colDefense;
        private System.Windows.Forms.ColumnHeader colBanlist;
        private System.Windows.Forms.ColumnHeader colCard_text;
        private System.Windows.Forms.Label lblYGO;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnDeckLists;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBanlist;
        private System.Windows.Forms.Label lblClickSomething;
    }
}