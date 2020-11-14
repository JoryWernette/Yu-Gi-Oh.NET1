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
    public partial class MainPage : Form
    {
        private CardHandler _cardHandler = new CardHandler();
        public MainPage()
        {
            InitializeComponent();
        }

        private void CardListForm_Load(object sender, EventArgs e)
        {
            populateList();
        }

        private void populateList()
        {
            lstCard.Items.Clear();
            for (int i = 0; i < _cardHandler.CardList.Count; i++)
            {
                this.lstCard.Items.Add(_cardHandler.CardList[i].Name);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Card_category);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Card_type);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Monster_type);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Sub_type);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Attribute);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Level_rank);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Attack);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Defense);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Banlist);
                this.lstCard.Items[this.lstCard.Items.Count - 1].SubItems.Add(_cardHandler.CardList[i].Card_text);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            populateList();
        }

        private void lstCard_DoubleClick(object sender, EventArgs e)
        {
            var newForm = new frmMain(_cardHandler, lstCard.SelectedIndices[0]);
            newForm.ShowDialog();
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
    } // End of MainPage Form
} // End of Yu_Gi_Oh
