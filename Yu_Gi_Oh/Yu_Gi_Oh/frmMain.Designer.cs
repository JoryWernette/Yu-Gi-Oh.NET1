namespace Yu_Gi_Oh
{
    partial class frmMain
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
            this.lblYuGiOh = new System.Windows.Forms.Label();
            this.btnBanlist = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeckLists = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSubType = new System.Windows.Forms.Label();
            this.lblAttribute = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.lblEffect_Flavor = new System.Windows.Forms.Label();
            this.lblBanned = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSubType = new System.Windows.Forms.TextBox();
            this.txtAttribute = new System.Windows.Forms.TextBox();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.txtDefense = new System.Windows.Forms.TextBox();
            this.txtEffect = new System.Windows.Forms.TextBox();
            this.txtBanlist = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtMonsterType = new System.Windows.Forms.TextBox();
            this.lblMonsterType = new System.Windows.Forms.Label();
            this.txtCardType = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.txtLevelRank = new System.Windows.Forms.TextBox();
            this.lblLevelRank = new System.Windows.Forms.Label();
            this.picRandCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRandCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYuGiOh
            // 
            this.lblYuGiOh.AutoSize = true;
            this.lblYuGiOh.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYuGiOh.Location = new System.Drawing.Point(12, 10);
            this.lblYuGiOh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYuGiOh.Name = "lblYuGiOh";
            this.lblYuGiOh.Size = new System.Drawing.Size(587, 168);
            this.lblYuGiOh.TabIndex = 0;
            this.lblYuGiOh.Text = "Yu-Gi-Oh!";
            // 
            // btnBanlist
            // 
            this.btnBanlist.Location = new System.Drawing.Point(886, 35);
            this.btnBanlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBanlist.Name = "btnBanlist";
            this.btnBanlist.Size = new System.Drawing.Size(160, 131);
            this.btnBanlist.TabIndex = 1;
            this.btnBanlist.Text = "Banlist";
            this.btnBanlist.UseVisualStyleBackColor = true;
            this.btnBanlist.Click += new System.EventHandler(this.btnBanlist_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1052, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 131);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Cards";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeckLists
            // 
            this.btnDeckLists.Location = new System.Drawing.Point(1218, 35);
            this.btnDeckLists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeckLists.Name = "btnDeckLists";
            this.btnDeckLists.Size = new System.Drawing.Size(160, 131);
            this.btnDeckLists.TabIndex = 3;
            this.btnDeckLists.Text = "Deck Lists";
            this.btnDeckLists.UseVisualStyleBackColor = true;
            this.btnDeckLists.Click += new System.EventHandler(this.btnDeckLists_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(1384, 35);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(160, 131);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(828, 200);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 37);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name: ";
            // 
            // lblSubType
            // 
            this.lblSubType.AutoSize = true;
            this.lblSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubType.Location = new System.Drawing.Point(828, 429);
            this.lblSubType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(172, 37);
            this.lblSubType.TabIndex = 8;
            this.lblSubType.Text = "Sub-Type: ";
            this.lblSubType.Click += new System.EventHandler(this.lblSubType_Click);
            // 
            // lblAttribute
            // 
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttribute.Location = new System.Drawing.Point(828, 485);
            this.lblAttribute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(155, 37);
            this.lblAttribute.TabIndex = 9;
            this.lblAttribute.Text = "Attribute: ";
            this.lblAttribute.Click += new System.EventHandler(this.lblAttribute_Click);
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack.Location = new System.Drawing.Point(828, 596);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(125, 37);
            this.lblAttack.TabIndex = 10;
            this.lblAttack.Text = "Attack: ";
            this.lblAttack.Click += new System.EventHandler(this.lblAttack_Click);
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefense.Location = new System.Drawing.Point(828, 654);
            this.lblDefense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(152, 37);
            this.lblDefense.TabIndex = 11;
            this.lblDefense.Text = "Defense: ";
            this.lblDefense.Click += new System.EventHandler(this.lblDefense_Click);
            // 
            // lblEffect_Flavor
            // 
            this.lblEffect_Flavor.AutoSize = true;
            this.lblEffect_Flavor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffect_Flavor.Location = new System.Drawing.Point(830, 710);
            this.lblEffect_Flavor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEffect_Flavor.Name = "lblEffect_Flavor";
            this.lblEffect_Flavor.Size = new System.Drawing.Size(116, 37);
            this.lblEffect_Flavor.TabIndex = 12;
            this.lblEffect_Flavor.Text = "Effect: ";
            this.lblEffect_Flavor.Click += new System.EventHandler(this.lblEffect_Click);
            // 
            // lblBanned
            // 
            this.lblBanned.AutoSize = true;
            this.lblBanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanned.Location = new System.Drawing.Point(828, 921);
            this.lblBanned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanned.Name = "lblBanned";
            this.lblBanned.Size = new System.Drawing.Size(131, 37);
            this.lblBanned.TabIndex = 13;
            this.lblBanned.Text = "Banlist: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1052, 187);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(492, 50);
            this.txtName.TabIndex = 14;
            this.txtName.Text = "Dark Magician";
            // 
            // txtSubType
            // 
            this.txtSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubType.Location = new System.Drawing.Point(1052, 415);
            this.txtSubType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubType.Name = "txtSubType";
            this.txtSubType.Size = new System.Drawing.Size(492, 50);
            this.txtSubType.TabIndex = 16;
            this.txtSubType.Text = "None";
            this.txtSubType.TextChanged += new System.EventHandler(this.txtSubType_TextChanged);
            // 
            // txtAttribute
            // 
            this.txtAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttribute.Location = new System.Drawing.Point(1052, 471);
            this.txtAttribute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAttribute.Name = "txtAttribute";
            this.txtAttribute.Size = new System.Drawing.Size(492, 50);
            this.txtAttribute.TabIndex = 17;
            this.txtAttribute.Text = "Dark";
            // 
            // txtAttack
            // 
            this.txtAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttack.Location = new System.Drawing.Point(1052, 585);
            this.txtAttack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(492, 50);
            this.txtAttack.TabIndex = 18;
            this.txtAttack.Text = "2500";
            // 
            // txtDefense
            // 
            this.txtDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefense.Location = new System.Drawing.Point(1052, 640);
            this.txtDefense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDefense.Name = "txtDefense";
            this.txtDefense.Size = new System.Drawing.Size(492, 50);
            this.txtDefense.TabIndex = 19;
            this.txtDefense.Text = "2100";
            // 
            // txtEffect
            // 
            this.txtEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEffect.Location = new System.Drawing.Point(1052, 696);
            this.txtEffect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEffect.Multiline = true;
            this.txtEffect.Name = "txtEffect";
            this.txtEffect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEffect.Size = new System.Drawing.Size(492, 206);
            this.txtEffect.TabIndex = 20;
            this.txtEffect.Text = "The ultimate wizard in terms of attack and defense.";
            // 
            // txtBanlist
            // 
            this.txtBanlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanlist.Location = new System.Drawing.Point(1052, 908);
            this.txtBanlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBanlist.Name = "txtBanlist";
            this.txtBanlist.Size = new System.Drawing.Size(492, 50);
            this.txtBanlist.TabIndex = 21;
            this.txtBanlist.Text = "Unlimited";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(828, 256);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(146, 37);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(1052, 242);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(492, 50);
            this.txtCategory.TabIndex = 25;
            this.txtCategory.Text = "Monster";
            // 
            // txtMonsterType
            // 
            this.txtMonsterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonsterType.Location = new System.Drawing.Point(1052, 360);
            this.txtMonsterType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonsterType.Name = "txtMonsterType";
            this.txtMonsterType.Size = new System.Drawing.Size(492, 50);
            this.txtMonsterType.TabIndex = 27;
            this.txtMonsterType.Text = "Spellcaster";
            // 
            // lblMonsterType
            // 
            this.lblMonsterType.AutoSize = true;
            this.lblMonsterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterType.Location = new System.Drawing.Point(828, 377);
            this.lblMonsterType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonsterType.Name = "lblMonsterType";
            this.lblMonsterType.Size = new System.Drawing.Size(220, 37);
            this.lblMonsterType.TabIndex = 26;
            this.lblMonsterType.Text = "Monster Type:";
            // 
            // txtCardType
            // 
            this.txtCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardType.Location = new System.Drawing.Point(1052, 298);
            this.txtCardType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCardType.Name = "txtCardType";
            this.txtCardType.Size = new System.Drawing.Size(492, 50);
            this.txtCardType.TabIndex = 29;
            this.txtCardType.Text = "Normal";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(828, 315);
            this.lblCardType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(175, 37);
            this.lblCardType.TabIndex = 28;
            this.lblCardType.Text = "Card Type:";
            // 
            // txtLevelRank
            // 
            this.txtLevelRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevelRank.Location = new System.Drawing.Point(1052, 529);
            this.txtLevelRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLevelRank.Name = "txtLevelRank";
            this.txtLevelRank.Size = new System.Drawing.Size(492, 50);
            this.txtLevelRank.TabIndex = 31;
            this.txtLevelRank.Text = "7";
            // 
            // lblLevelRank
            // 
            this.lblLevelRank.AutoSize = true;
            this.lblLevelRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelRank.Location = new System.Drawing.Point(828, 540);
            this.lblLevelRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevelRank.Name = "lblLevelRank";
            this.lblLevelRank.Size = new System.Drawing.Size(183, 37);
            this.lblLevelRank.TabIndex = 30;
            this.lblLevelRank.Text = "Level/Rank:";
            // 
            // picRandCard
            // 
            this.picRandCard.BackColor = System.Drawing.SystemColors.Desktop;
            this.picRandCard.BackgroundImage = global::Yu_Gi_Oh.Properties.Resources.Dark_Magician_LOB;
            this.picRandCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRandCard.Location = new System.Drawing.Point(110, 229);
            this.picRandCard.Margin = new System.Windows.Forms.Padding(4);
            this.picRandCard.Name = "picRandCard";
            this.picRandCard.Size = new System.Drawing.Size(618, 867);
            this.picRandCard.TabIndex = 5;
            this.picRandCard.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1634, 1029);
            this.Controls.Add(this.txtLevelRank);
            this.Controls.Add(this.lblLevelRank);
            this.Controls.Add(this.txtCardType);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.txtMonsterType);
            this.Controls.Add(this.lblMonsterType);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtBanlist);
            this.Controls.Add(this.txtEffect);
            this.Controls.Add(this.txtDefense);
            this.Controls.Add(this.txtAttack);
            this.Controls.Add(this.txtAttribute);
            this.Controls.Add(this.txtSubType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBanned);
            this.Controls.Add(this.lblEffect_Flavor);
            this.Controls.Add(this.lblDefense);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.lblAttribute);
            this.Controls.Add(this.lblSubType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picRandCard);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnDeckLists);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBanlist);
            this.Controls.Add(this.lblYuGiOh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1660, 1100);
            this.MinimumSize = new System.Drawing.Size(1356, 840);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yu-Gi-Oh!";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picRandCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYuGiOh;
        private System.Windows.Forms.Button btnBanlist;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeckLists;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox picRandCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSubType;
        private System.Windows.Forms.Label lblAttribute;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.Label lblEffect_Flavor;
        private System.Windows.Forms.Label lblBanned;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubType;
        private System.Windows.Forms.TextBox txtAttribute;
        private System.Windows.Forms.TextBox txtAttack;
        private System.Windows.Forms.TextBox txtDefense;
        private System.Windows.Forms.TextBox txtEffect;
        private System.Windows.Forms.TextBox txtBanlist;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtMonsterType;
        private System.Windows.Forms.Label lblMonsterType;
        private System.Windows.Forms.TextBox txtCardType;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.TextBox txtLevelRank;
        private System.Windows.Forms.Label lblLevelRank;
    }
}

