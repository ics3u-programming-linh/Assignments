using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterGame21LinhH
{
    public partial class frmBetterGame : Form
    {
        // create a list for the deck of Cards
        List<Image> listCardImages = new List<Image>();

        // create a list for card values
        List<int> listDeckValues = new List<int>();

        // declare variables
        int randomLocation;
        Random randomNumberGenerator = new Random();

        public frmBetterGame()
        {
            InitializeComponent();
            // Call function
            CardsDown();
        }

        private void NewGame()
        {
            // enable buttons
            btnHit.Enabled = true;
            btnStay.Enabled = false;

        }
        private void CardsDown()
        {
            // Create a function that set cards to back cover
            picUCard3.Image = Properties.Resources.Back;

            picDCard.Image = Properties.Resources.Back;
            picDCard2.Image = Properties.Resources.Back;
            picDCard3.Image = Properties.Resources.Back;
        }

        private void NewDeck()
        {
            // Populate list with 52 cards
            listCardImages.Add(Properties.Resources._2C);
            listCardImages.Add(Properties.Resources._2D);
            listCardImages.Add(Properties.Resources._2H);
            listCardImages.Add(Properties.Resources._2S);

            listCardImages.Add(Properties.Resources._3C);
            listCardImages.Add(Properties.Resources._3D);
            listCardImages.Add(Properties.Resources._3H);
            listCardImages.Add(Properties.Resources._3S);

            listCardImages.Add(Properties.Resources._4C);
            listCardImages.Add(Properties.Resources._4D);
            listCardImages.Add(Properties.Resources._4H);
            listCardImages.Add(Properties.Resources._4S);

            listCardImages.Add(Properties.Resources._5C);
            listCardImages.Add(Properties.Resources._5D);
            listCardImages.Add(Properties.Resources._5H);
            listCardImages.Add(Properties.Resources._5S);

            listCardImages.Add(Properties.Resources._6C);
            listCardImages.Add(Properties.Resources._6D);
            listCardImages.Add(Properties.Resources._6H);
            listCardImages.Add(Properties.Resources._6S);

            listCardImages.Add(Properties.Resources._7C);
            listCardImages.Add(Properties.Resources._7D);
            listCardImages.Add(Properties.Resources._7H);
            listCardImages.Add(Properties.Resources._7S);

            listCardImages.Add(Properties.Resources._8C);
            listCardImages.Add(Properties.Resources._8D);
            listCardImages.Add(Properties.Resources._8H);
            listCardImages.Add(Properties.Resources._8S);

            listCardImages.Add(Properties.Resources._9C);
            listCardImages.Add(Properties.Resources._9D);
            listCardImages.Add(Properties.Resources._9H);
            listCardImages.Add(Properties.Resources._9S);

            listCardImages.Add(Properties.Resources._10C);
            listCardImages.Add(Properties.Resources._10D);
            listCardImages.Add(Properties.Resources._10H);
            listCardImages.Add(Properties.Resources._10S);

            listCardImages.Add(Properties.Resources.JC);
            listCardImages.Add(Properties.Resources.JD);
            listCardImages.Add(Properties.Resources.JH);
            listCardImages.Add(Properties.Resources.JS);

            listCardImages.Add(Properties.Resources.KC);
            listCardImages.Add(Properties.Resources.KD);
            listCardImages.Add(Properties.Resources.KH);
            listCardImages.Add(Properties.Resources.KS);

            listCardImages.Add(Properties.Resources.QC);
            listCardImages.Add(Properties.Resources.QD);
            listCardImages.Add(Properties.Resources.QH);
            listCardImages.Add(Properties.Resources.QS);

            listCardImages.Add(Properties.Resources.AC);
            listCardImages.Add(Properties.Resources.AD);
            listCardImages.Add(Properties.Resources.AH);
            listCardImages.Add(Properties.Resources.AS);
        }

        private void DealCard(ref PictureBox aCardBox, int randomIndex)
        {
            // set the card to a picture from the listBox at a randomIndex
            Image card = listCardImages[randomIndex];
            aCardBox.Image = card;
            
            // remove the randomIndex from the list
            listCardImages.RemoveAt(randomIndex);

        }

        private void GenerateRandomNumber()
        {
            // generate a random number
            randomLocation = randomNumberGenerator.Next(0, listCardImages.Count() - 1);
        }

        private void Reshuffle()
        {
            if (listCardImages.Count() <= 0)
            {
                // show message box if cards run out
                MessageBox.Show("Ran out of cards. Deck is reshuffling.");

                // clear images
                this.listCardImages.Clear();

                // Call New Deck and Cards Down
                CardsDown();
                NewDeck();
            }
            else
            {
                // call generate random number function
                GenerateRandomNumber();
            }
        }

        private void GenerateCardPic()
        {
            if (listCardImages.Count() > 0)
            {
                // call generate random number
                GenerateRandomNumber();
            }
            else
            {
                Reshuffle();
            }
        }
        private void BtnHit_Click(object sender, EventArgs e)
        {

        }

        private void BtnStay_Click(object sender, EventArgs e)
        {

        }

        private void PicUCard_Click(object sender, EventArgs e)
        {
            // Call generate random number function
            Reshuffle();

            // Call the deal card function 
            DealCard(ref this.picUCard, randomLocation);
            
            
        }
    }
}
