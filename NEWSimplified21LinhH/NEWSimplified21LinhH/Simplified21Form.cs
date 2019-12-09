/*
 * Created by: Linh Ho
 * Created on: December 6th, 2019
 * Created for: ICS3U Programming
 * Assignment #5b - Simplified 21
 * This program...is a version 2.0 of simplified 21 game.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWSimplified21LinhH
{
    public partial class frmSimplified21 : Form
    {
        // Create a list for deck of cards and card values
        List<Image> listDeckOfCards = new List<Image>();
        List<int> listDeckOfValues = new List<int>();

        // Declare variables and constants
        Random randomNumberGenerator = new Random();
        int randomNumber, playerFirstCard, playerSecondCard, playerTotal = 0;

        public frmSimplified21()
        {
            InitializeComponent();
            // call cards hide
            CardsHide();

            // Hide
            grbTotal.Hide();
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Hide labels, buttons, images, and etc
            btnStart.Hide();
            lblSimplified21.Hide();

            // show labels, buttons, images, and etc
            grbTotal.Show();

            // call cards shown
            CreateDeck();
            StartItems();

            CardsShown();

        }

        private void StartItems()
        {
            // display images
            picBacground.Show();
            btnStart.Show();
            lblSimplified21.Show();

            // call the cards down and cards hide
            CardsDown();
            CardsHide();

            // call generate two cards
            GenerateTwoCards();

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }

        private void MniNewGame_Click(object sender, EventArgs e)
        {

        }
        private void CardsDown()
        {
            // Set all images to the back of the card
            picDealerCard.Image = Properties.Resources.Back;
            picDealerCard2.Image = Properties.Resources.Back;
            picDealerCard3.Image = Properties.Resources.Back;

            picPlayerCard.Image = Properties.Resources.Back;
            picPlayerCard2.Image = Properties.Resources.Back;
            picPlayerCard3.Image = Properties.Resources.Back;
        }

        private void CardsShown()
        {
            // show all the cards
            picDealerCard.Show();
            picDealerCard2.Show();
            picDealerCard3.Show();
            picPlayerCard.Show();
            picPlayerCard2.Show();
            picPlayerCard3.Show();
        }

        private void CardsHide()
        {
            // hide all the cards
            picDealerCard.Hide();
            picDealerCard2.Hide();
            picDealerCard3.Hide();
            picPlayerCard.Hide();
            picPlayerCard2.Hide();
            picPlayerCard3.Hide();
        }

        //private void GenerateRandomNumber()
        //{

       // }
        private void CreateDeck()
        {
            #region Add Cards
            // populate the list with 52 cards
            listDeckOfCards.Add(Properties.Resources.AC);
            listDeckOfCards.Add(Properties.Resources.AD);
            listDeckOfCards.Add(Properties.Resources.AH);
            listDeckOfCards.Add(Properties.Resources.AS);

            listDeckOfCards.Add(Properties.Resources._2C);
            listDeckOfCards.Add(Properties.Resources._2D);
            listDeckOfCards.Add(Properties.Resources._2H);
            listDeckOfCards.Add(Properties.Resources._2S);

            listDeckOfCards.Add(Properties.Resources._3C);
            listDeckOfCards.Add(Properties.Resources._3D);
            listDeckOfCards.Add(Properties.Resources._3H);
            listDeckOfCards.Add(Properties.Resources._3S);

            listDeckOfCards.Add(Properties.Resources._4C);
            listDeckOfCards.Add(Properties.Resources._4D);
            listDeckOfCards.Add(Properties.Resources._4H);
            listDeckOfCards.Add(Properties.Resources._4S);

            listDeckOfCards.Add(Properties.Resources._5C);
            listDeckOfCards.Add(Properties.Resources._5D);
            listDeckOfCards.Add(Properties.Resources._5H);
            listDeckOfCards.Add(Properties.Resources._5S);

            listDeckOfCards.Add(Properties.Resources._6C);
            listDeckOfCards.Add(Properties.Resources._6D);
            listDeckOfCards.Add(Properties.Resources._6H);
            listDeckOfCards.Add(Properties.Resources._6S);

            listDeckOfCards.Add(Properties.Resources._7C);
            listDeckOfCards.Add(Properties.Resources._7D);
            listDeckOfCards.Add(Properties.Resources._7H);
            listDeckOfCards.Add(Properties.Resources._7S);

            listDeckOfCards.Add(Properties.Resources._8C);
            listDeckOfCards.Add(Properties.Resources._8D);
            listDeckOfCards.Add(Properties.Resources._8H);
            listDeckOfCards.Add(Properties.Resources._8S);

            listDeckOfCards.Add(Properties.Resources._9C);
            listDeckOfCards.Add(Properties.Resources._9D);
            listDeckOfCards.Add(Properties.Resources._9H);
            listDeckOfCards.Add(Properties.Resources._9S);

            listDeckOfCards.Add(Properties.Resources._10C);
            listDeckOfCards.Add(Properties.Resources._10D);
            listDeckOfCards.Add(Properties.Resources._10H);
            listDeckOfCards.Add(Properties.Resources._10S);

            listDeckOfCards.Add(Properties.Resources.JC);
            listDeckOfCards.Add(Properties.Resources.JD);
            listDeckOfCards.Add(Properties.Resources.JH);
            listDeckOfCards.Add(Properties.Resources.JS);

            listDeckOfCards.Add(Properties.Resources.KC);
            listDeckOfCards.Add(Properties.Resources.KD);
            listDeckOfCards.Add(Properties.Resources.KH);
            listDeckOfCards.Add(Properties.Resources.KS);

            listDeckOfCards.Add(Properties.Resources.QC);
            listDeckOfCards.Add(Properties.Resources.QD);
            listDeckOfCards.Add(Properties.Resources.QH);
            listDeckOfCards.Add(Properties.Resources.QS);

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

            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);
            listDeckOfValues.Add(10);

        }

        private void CreateDeckValues()
        {
            // populate list with card values


        }

        private int DealCard(ref PictureBox aPictureBox, int randNum)
        {
            int cardValue;


            // set the randomNumber from list to the image
            Image card = listDeckOfCards[randNum];

            // set the card to a picture from the listBox at a randomIndex
            aPictureBox.Image = card;

            // get value of card
            cardValue = listDeckOfValues[randNum];

            // remove the deck of cards and values from their own list
            listDeckOfCards.RemoveAt(randNum);

            // remove the deck of cards and values from their own list
            listDeckOfValues.RemoveAt(randNum);

            // return value
            return cardValue;
        }

        private void GenerateTwoCards()
        {
            // generate a random number
            randomNumber = randomNumberGenerator.Next(0, listDeckOfCards.Count() - 1);
            // display two randomly generated cards
            playerFirstCard = DealCard(ref this.picPlayerCard, randomNumber);

            // generate a random number
            randomNumber = randomNumberGenerator.Next(0, listDeckOfCards.Count() - 1);
            playerSecondCard = DealCard(ref this.picPlayerCard2, randomNumber);

            playerTotal = playerFirstCard + playerSecondCard;
            lblPlayerTotalAns.Text = playerTotal + "";
        }
    }

}
