using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;

namespace Yu_Gi_Oh
{
    public partial class frmMain : Form
    {
        CardHandler _cardHandler;
        int _cardIndex;
        CardInfo _cardInfo;
        public frmMain(CardHandler cardHandler, int cardIndex)
        {
            InitializeComponent();
            _cardHandler = cardHandler;
            _cardIndex = cardIndex;            
        }
        private void frmMain_Load_1(object sender, EventArgs e)
        {
            DisplayCardInfo();
        }
        private void DisplayCardInfo() 
        {
            try
            {
                _cardInfo = _cardHandler.getCardInfo(_cardIndex);
                this.txtName.Text = _cardInfo.Name;
                this.txtCategory.Text = _cardInfo.Card_category;
                this.txtCardType.Text = _cardInfo.Card_type;
                this.txtMonsterType.Text = _cardInfo.Monster_type;
                this.txtSubType.Text = _cardInfo.Sub_type;
                this.txtAttribute.Text = _cardInfo.Attribute;
                this.txtLevelRank.Text = _cardInfo.Level_rank;
                this.txtAttack.Text = _cardInfo.Attack;
                this.txtDefense.Text = _cardInfo.Defense;
                this.txtEffect.Text = _cardInfo.Card_text;
                this.txtBanlist.Text = _cardInfo.Banlist;
                this.picRandCard.Image = Image.FromFile(AppData.DataPath + @"\" + _cardHandler.CardList[_cardIndex].Card_Image_File);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSubType_Click(object sender, EventArgs e)
        {

        }

        private void lblAttribute_Click(object sender, EventArgs e)
        {

        }

        private void lblDefense_Click(object sender, EventArgs e)
        {

        }

        private void lblAttack_Click(object sender, EventArgs e)
        {

        }

        private void lblEffect_Click(object sender, EventArgs e)
        {

        }

        private void txtSubType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBanlist_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This button is still under construction.\nHere, a player would be able to see the Banlist.\nThis could be in the form of a webpage or a prefilled table.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This button is still under construction.\nHere, a player would be able to refine their search for cards\n based on card descriptions, like attack points or type...");

        }

        private void btnDeckLists_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This button is still under construction.\nHere a player would get to see the saved decks in the system.");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This button is still under construction.\nHere, a player would enter their Konami ID to see the decks they have made.");
        }
    }
}
