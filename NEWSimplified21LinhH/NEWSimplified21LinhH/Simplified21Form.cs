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
// add sound media
using System.Media;
namespace NEWSimplified21LinhH
{
    public partial class frmSimplified21 : Form
    {
        // Create a list for deck of cards and card values
        List<Image> listDeckOfCards = new List<Image>();
        List<int> listDeckOfValues = new List<int>();

        // Add sound
        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"N:\Classes\Sem1-Fall2019\ICS3U Programming\HLinh (s272936)\Assignments\NEWSimplified21LinhH\NEWSimplified21LinhH\Sounds\instrumental.wav");

        // Declare variables and constants
        Random randomNumberGenerator = new Random();
        int randomNumber, playerFirstCard = 0, playerSecondCard = 0, playerThirdCard = 0;
        int dealerFirstCard = 0, dealerSecondCard = 0, dealerThirdCard = 0, dealerFourthCard = 0;
        int playerTotal = 0, dealerTotal = 0;
        int gamesPlayedTotal = 0, dealerWinTotal = 0, playerWinTotal = 0;

        public frmSimplified21()
        {
            InitializeComponent();

            // Play the sound
            soundPlayer.Play();

            // Loop sound
            soundPlayer.PlayLooping();

            // call cards hide
            CardsHide();
            CreateDeck();

            // hide grb, labels, buttons, and etc
            grbHitOrStay.Hide();
            grbTotal.Hide();
            btnRestart.Hide();
            picDealerCard4.Hide();
            lblDealerWins.Hide();
            lblPlayerWins.Hide();

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Call next page
            NextRound();
        }

        private void NextRound()
        {
            #region next round
            // Hide labels, buttons, images, and etc
            btnStart.Hide();
            lblSimplified21.Hide();

            // call function to create and hide deck
            CreateDeck();
            CardsShown();

            // Call to generate two cards
            GenerateTwoCards();

            // show labels, images, buttons and etc.
            grbTotal.Show();
            grbHitOrStay.Show();
            btnRestart.Show();
            lblPlayerWins.Show();
            lblDealerWins.Show();

            // disable restart button
            btnRestart.Enabled = false;
            #endregion
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }

        private void MniNewGame_Click(object sender, EventArgs e)
        {
            // clear the list of cards and card values
            listDeckOfCards.Clear();
            listDeckOfValues.Clear();

            // call new game
            Restart();
        }

        private void ResetVariables()
        {
            #region reset variables
            // reset variables 
            playerFirstCard = 0;
            playerSecondCard = 0;
            playerThirdCard = 0;
            dealerFirstCard = 0;
            dealerSecondCard = 0;
            dealerThirdCard = 0;
            dealerFourthCard = 0;
            playerTotal = 0;
            dealerTotal = 0;
            gamesPlayedTotal = 0;
            dealerWinTotal = 0;
            playerWinTotal = 0;

            // display games played total 
            lblGamesPlayedTotal.Text = "";
            #endregion
        }
        private void Restart()
        {
            #region Restart
            // Call create deck and reset variables function
            ResetVariables();

            // call cards hide and face down
            CardsHide();
            CardsDown();

            // hide labels, buttons, and etc
            grbHitOrStay.Hide();
            grbTotal.Hide();
            picDealerCard4.Hide();
            btnRestart.Hide();

            // Show labels, pictures, and etc.
            lblSimplified21.Show();
            btnStart.Show();

            // enable hit and stay
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            // set labels to nothing
            lblDealerTotalAns.Text = "";
            lblPlayerTotalAns.Text = "";
            lblPlayerWins.Text = "";
            lblDealerWins.Text = "";
            #endregion

        }
        private void CardsDown()
        {
            #region Images set to back face
            // Set all images to the back of the card
            picDealerCard.Image = Properties.Resources.Back;
            picDealerCard2.Image = Properties.Resources.Back;
            picDealerCard3.Image = Properties.Resources.Back;
            picDealerCard4.Image = Properties.Resources.Back;

            picPlayerCard.Image = Properties.Resources.Back;
            picPlayerCard2.Image = Properties.Resources.Back;
            picPlayerCard3.Image = Properties.Resources.Back;
            
            #endregion 
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            #region NewRound
            // Hide labels, buttons, images, and etc
            btnStart.Hide();
            lblSimplified21.Hide();

            // loop through each object on the form
            foreach (Control aControlObject in this.Controls)
            {
                //  if the object is a button, make it gray
                if (aControlObject.GetType() == typeof(Button))
                {
                    aControlObject.BackColor = Color.Gray;
                }
            }

            // call function to create and hide deck
            CreateDeck();
            CardsDown();
            CardsShown();

            // call games played
            GamesPlayed();

            // Call to generate two cards
            GenerateTwoCards();

            // show labels, images, buttons and etc.
            grbTotal.Show();
            grbHitOrStay.Show();
            btnRestart.Show();

            // enable and disable buttons, images, and etc
            btnHit.Enabled = true;
            btnStay.Enabled = true;
            btnRestart.Enabled = false;

            // reset total
            lblPlayerTotalAns.Text = "";
            lblDealerTotalAns.Text = "";

            #endregion
        }

        private void CardsShown()
        {
            #region Show cards
            // show all the cards
            picDealerCard.Show();
            picDealerCard2.Show();
            picDealerCard3.Show();
            picPlayerCard.Show();
            picPlayerCard2.Show();
            picPlayerCard3.Show();
            #endregion
        }

        private void CardsHide()
        {
            #region Hide cards
            // hide all the cards
            picDealerCard.Hide();
            picDealerCard2.Hide();
            picDealerCard3.Hide();
            picPlayerCard.Hide();
            picPlayerCard2.Hide();
            picPlayerCard3.Hide();
            #endregion
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            // disable hit and stay button
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            // enable restart button
            btnRestart.Enabled = true;

            // display the dealer's three randomly chosen cards
            dealerFirstCard = DealCard(ref this.picDealerCard);
            dealerSecondCard = DealCard(ref this.picDealerCard2);
            dealerThirdCard = DealCard(ref this.picDealerCard3);

            // Call calculate total
            CalculateTotal();

            // check to see if dealerTotal is less than 17
            if (dealerTotal < 17)
            {
                // display fourth dealer card
                picDealerCard4.Show();

                // generate 4th card
                dealerFourthCard = DealCard(ref this.picDealerCard4);

                // display total
                CalculateTotal();
            }

            // call determine winner
            DetermineWinner();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display message box
            MessageBox.Show("Use hit to draw another card and use stay to have your remaining cards.");
        }

        private void MniInstructions_Click(object sender, EventArgs e)
        {
            // display message box
            MessageBox.Show("The main object of the game is to score 21. If you score more than 21, you lose. Even if the dealer scores higher. You can only win if you get blackjack, tie, or score higher than dealer while having your total score less/equal to 21. Not to mention, if dealer scores over 21, you automatically win.");
        }

        private void CalculateTotal()
        {
            // calculate the total
            dealerTotal = dealerFirstCard + dealerSecondCard + dealerThirdCard + dealerFourthCard;

            // Display the total
            lblDealerTotalAns.Text = dealerTotal + "";

            // Calculate the player total
            playerTotal = playerFirstCard + playerSecondCard + playerThirdCard;

            // Display the total
            lblPlayerTotalAns.Text = playerTotal + "";
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            // generate a random number
            randomNumber = randomNumberGenerator.Next(0, listDeckOfCards.Count() - 1);

            // get the third player card
            playerThirdCard = DealCard(ref this.picPlayerCard3);

            // call calculate total
            CalculateTotal();

            // disable hit button
            btnHit.Enabled = false;
       
        }

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

            listDeckOfCards.Add(Properties.Resources.QC);
            listDeckOfCards.Add(Properties.Resources.QD);
            listDeckOfCards.Add(Properties.Resources.QH);
            listDeckOfCards.Add(Properties.Resources.QS);

            listDeckOfCards.Add(Properties.Resources.KC);
            listDeckOfCards.Add(Properties.Resources.KD);
            listDeckOfCards.Add(Properties.Resources.KH);
            listDeckOfCards.Add(Properties.Resources.KS);

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
            #endregion
        }

        private int DealCard(ref PictureBox aPictureBox)
        {
            // See if there are less than 6 cards
            if (listDeckOfCards.Count() <= 6)
            {
                // Clear deck
                listDeckOfCards.Clear();
                listDeckOfValues.Clear();

                // Create deck
                CreateDeck();

                // Display a messagebox
                MessageBox.Show("You ran out of cards. Deck is reshuffling.");
            }

            // declare variables
            int cardValue;

            // set the randomNumber from list to the image
            Image card = listDeckOfCards[randomNumber];

            // set the card to a picture from the listBox at a randomIndex
            aPictureBox.Image = card;

            // get value of card
            cardValue = listDeckOfValues[randomNumber];

            // remove the deck of cards and values from their own list
            listDeckOfCards.RemoveAt(randomNumber);
            listDeckOfValues.RemoveAt(randomNumber);

            // return value
            return cardValue;
        }

        private void GenerateTwoCards()
        {
            // generate a random number
            randomNumber = randomNumberGenerator.Next(0, listDeckOfCards.Count() - 1);

            // display two randomly generated cards
            playerFirstCard = DealCard(ref this.picPlayerCard);

            // generate a random number
            randomNumber = randomNumberGenerator.Next(0, listDeckOfCards.Count() - 1);

            // display reference card to the player card
            playerSecondCard = DealCard(ref this.picPlayerCard2);

            // calculate and display total
            playerTotal = playerFirstCard + playerSecondCard;
            lblPlayerTotalAns.Text = playerTotal + "";
        }

        private void DetermineWinner()
        {
            #region Determine winner
            // check to see who won
            if (playerTotal > 21 && playerTotal > 21)
            {
                // display message box that user lost
                MessageBox.Show("You went over 21. You lose.");

                // call win count function
                UpdateDealerWins();
            }
            else if (dealerTotal > 21)
            {
                // display message box that user won
                MessageBox.Show("The dealer busted, you win!");

                // call win count function
                UpdatePlayerWins();
            }
            else if (playerTotal > 21)
            {
                // display message box that user lost
                MessageBox.Show("You busted. You lose!");

                // call win count function
                UpdateDealerWins();
            }
            else if (dealerTotal > playerTotal)
            {
                // Display a message box that the user has lost.
                MessageBox.Show("Dealer scored higher. You lose.");

                // call win count function
                UpdateDealerWins();
            }
            else if (playerTotal > dealerTotal)
            {
                // Display a message box that the user has won
                MessageBox.Show("You scored higher. Congratulations, you won!");

                // call win count function
                UpdatePlayerWins();
            }
            else if (dealerTotal == 21)
            {
                // Display a message box that the computer has won
                MessageBox.Show("Dealer got 21, blackjack. Try again!");

                // call win count function
                UpdateDealerWins();
            }
            else if (playerTotal == 21)
            {
                // Display a message box that the user has won
                MessageBox.Show("You have won! Blackjack!");

                // call win count function
                UpdatePlayerWins();
            }
            else
            {
                // Display a message box that the user has tied with the dealer.
                MessageBox.Show("It's a tie!");

                // call win count function
                UpdateDealerWins();
            }
            #endregion
        }

        private void GamesPlayed()
        {
            // increment games played 
            gamesPlayedTotal = gamesPlayedTotal + 1;

            // display games played
            lblGamesPlayedTotal.Text = ("Games Played: " + gamesPlayedTotal); 
        }

        private void UpdatePlayerWins()
        {
            // increment player wins
            playerWinTotal = playerWinTotal + 1;

            // display wins
            lblPlayerWins.Text = "Player Wins: " + playerWinTotal;
        }

        private void UpdateDealerWins()
        {
            // increment dealer wins
            dealerWinTotal = dealerWinTotal + 1;

            // display wins
            lblDealerWins.Text = "Dealer Wins: " + dealerWinTotal;
        }
    }

}
