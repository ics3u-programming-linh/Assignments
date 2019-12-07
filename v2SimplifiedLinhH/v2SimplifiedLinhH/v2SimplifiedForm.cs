using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2SimplifiedLinhH
{
    public partial class frmV2Simplified : Form
    {
        
        // Create a list for deck of cards and card values
        List<Image> listDeckOfCards = new List<Image>();
        List<int> listDeckOfValues = new List<int>();

        // Declare variables and constants
        Random randomNumberGenerator = new Random();
        int randomNumber, playerScore, dealerScore, userTotal, dealerTotal;

        const int MIN_NUM = 1;
        const int MAX_NUM = 11;
        const int BLACKJACK = 21;

        public frmV2Simplified()
        {
            InitializeComponent();
            // Call function/procedures
            CreateDeck();
            CreateValues();

            // disable hit and stay
            btnHit.Enabled = false;
            btnStay.Enabled = false;
            
        }
        private void CreateDeck()
        {
            // populate the list with 52 cards
            listDeckOfCards.Insert(0, Properties.Resources.AC);
            listDeckOfCards.Insert(1, Properties.Resources.AD);
            listDeckOfCards.Insert(2, Properties.Resources.AH);
            listDeckOfCards.Insert(3, Properties.Resources.AS);

            listDeckOfCards.Insert(4, Properties.Resources._2C);
            listDeckOfCards.Insert(5, Properties.Resources._2D);
            listDeckOfCards.Insert(6, Properties.Resources._2H);
            listDeckOfCards.Insert(7, Properties.Resources._2S);

            listDeckOfCards.Insert(8, Properties.Resources._3C);
            listDeckOfCards.Insert(9, Properties.Resources._3D);
            listDeckOfCards.Insert(10, Properties.Resources._3H);
            listDeckOfCards.Insert(11, Properties.Resources._3S);

            listDeckOfCards.Insert(12, Properties.Resources._4C);
            listDeckOfCards.Insert(13, Properties.Resources._4D);
            listDeckOfCards.Insert(14, Properties.Resources._4H);
            listDeckOfCards.Insert(15, Properties.Resources._4S);

            listDeckOfCards.Insert(16, Properties.Resources._5C);
            listDeckOfCards.Insert(17, Properties.Resources._5D);
            listDeckOfCards.Insert(18, Properties.Resources._5H);
            listDeckOfCards.Insert(19, Properties.Resources._5S);

            listDeckOfCards.Insert(20, Properties.Resources._6C);
            listDeckOfCards.Insert(21, Properties.Resources._6D);
            listDeckOfCards.Insert(22, Properties.Resources._6H);
            listDeckOfCards.Insert(23, Properties.Resources._6S);

            listDeckOfCards.Insert(24, Properties.Resources._7C);
            listDeckOfCards.Insert(25, Properties.Resources._7D);
            listDeckOfCards.Insert(26, Properties.Resources._7H);
            listDeckOfCards.Insert(27, Properties.Resources._7S);

            listDeckOfCards.Insert(28, Properties.Resources._8C);
            listDeckOfCards.Insert(29, Properties.Resources._8D);
            listDeckOfCards.Insert(30, Properties.Resources._8H);
            listDeckOfCards.Insert(31, Properties.Resources._8S);

            listDeckOfCards.Insert(32, Properties.Resources._9C);
            listDeckOfCards.Insert(33, Properties.Resources._9D);
            listDeckOfCards.Insert(34, Properties.Resources._9H);
            listDeckOfCards.Insert(35, Properties.Resources._9S);

            listDeckOfCards.Insert(36, Properties.Resources._10C);
            listDeckOfCards.Insert(37, Properties.Resources._10D);
            listDeckOfCards.Insert(38, Properties.Resources._10H);
            listDeckOfCards.Insert(39, Properties.Resources._10S);

            listDeckOfCards.Insert(40, Properties.Resources.JC);
            listDeckOfCards.Insert(41, Properties.Resources.JD);
            listDeckOfCards.Insert(42, Properties.Resources.JH);
            listDeckOfCards.Insert(43, Properties.Resources.JS);

            listDeckOfCards.Insert(44, Properties.Resources.KC);
            listDeckOfCards.Insert(45, Properties.Resources.KD);
            listDeckOfCards.Insert(46, Properties.Resources.KH);
            listDeckOfCards.Insert(47, Properties.Resources.KS);

            listDeckOfCards.Insert(48, Properties.Resources.QC);
            listDeckOfCards.Insert(49, Properties.Resources.QD);
            listDeckOfCards.Insert(50, Properties.Resources.QH);
            listDeckOfCards.Insert(51, Properties.Resources.QS);
        }

        private void CreateValues()
        {
            // populate list with card values
            listDeckOfValues.Add(1);
            listDeckOfValues.Add(1);
            listDeckOfValues.Add(1);
            listDeckOfValues.Add(1);

            listDeckOfValues.Add(2);
            listDeckOfValues.Add(2);
            listDeckOfValues.Add(2);
            listDeckOfValues.Add(2);

            listDeckOfValues.Add(3);
            listDeckOfValues.Add(3);
            listDeckOfValues.Add(3);
            listDeckOfValues.Add(3);

            listDeckOfValues.Add(4);
            listDeckOfValues.Add(4);
            listDeckOfValues.Add(4);
            listDeckOfValues.Add(4);

            listDeckOfValues.Add(4);
            listDeckOfValues.Add(4);
            listDeckOfValues.Add(4);
            listDeckOfValues.Add(4);

            listDeckOfValues.Add(5);
            listDeckOfValues.Add(5);
            listDeckOfValues.Add(5);
            listDeckOfValues.Add(5);

            listDeckOfValues.Add(6);
            listDeckOfValues.Add(6);
            listDeckOfValues.Add(6);
            listDeckOfValues.Add(6);

            listDeckOfValues.Add(7);
            listDeckOfValues.Add(7);
            listDeckOfValues.Add(7);
            listDeckOfValues.Add(7);

            listDeckOfValues.Add(8);
            listDeckOfValues.Add(8);
            listDeckOfValues.Add(8);
            listDeckOfValues.Add(8);

            listDeckOfValues.Add(9);
            listDeckOfValues.Add(9);
            listDeckOfValues.Add(9);
            listDeckOfValues.Add(9);

            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);

            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);

            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
        }

        private void GenerateRandomNumber()
        {
            // generate a random number
            randomNumber = randomNumberGenerator.Next(0, listDeckOfCards.Count() - 1);
        }

        private int DealCard(ref PictureBox aPictureBox)
        {
            // declare variables
            int cardValue = -1;

            // if there are less than 6 cards, create new deck
            if (listDeckOfCards.Count() <= 6)
            {
                CreateDeck();
                MessageBox.Show("You ran out of cards. Deck is reshuffling.");
            }
            else
            {
                // generate a random number
                randomNumber = randomNumberGenerator.Next(0, listDeckOfCards.Count() - 1);

                // set the card to a picture from the listBox at a randomIndex
                aPictureBox.Image = listDeckOfCards[randomNumber];

                // get value of card
                cardValue = listDeckOfValues[randomNumber];

                // remove the deck of cards and values from their own list
                listDeckOfCards.RemoveAt(randomNumber);
                listDeckOfValues.Remove(randomNumber);
            }

            // return value
            return cardValue;

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Set all images to the back of the card
            picUCard3.Image = Properties.Resources.Back;
            picDCard.Image = Properties.Resources.Back;
            picDCard2.Image = Properties.Resources.Back;
            picDCard3.Image = Properties.Resources.Back;

            // hide label
            picUCard3.Hide();

            // Disable/Enable buttons
            btnStart.Enabled = false;
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            // declare variables
            int uValue, uValue2;

            // display two randomly generated cards
            uValue = DealCard(ref this.picUCard);
            uValue2 = DealCard(ref this.picUCard2);

            // calculate player score
            playerScore = uValue + uValue2;

            // Convert from int to string
            lblPlayerScore.Text = Convert.ToString(playerScore);
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {

        }

        private void BtnStay_Click(object sender, EventArgs e)
        {

        }
    }
}
