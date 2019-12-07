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

namespace v2SimplifiedLinhH
{
    public partial class frmV2Simplified : Form
    {

        // Create a list for deck of cards and card values
        List<Image> listDeckOfCards = new List<Image>();
        List<int> listDeckOfValues = new List<int>();

        // Declare variables and constants
        Random randomNumberGenerator = new Random();
        int randomNumber, playerScore = 0, dealerScore = 0, uValue = 0, uValue2 = 0, uValue3 = 0, dValue = 0, dValue2 = 0, dValue3 = 0, gamesPlayedCount, playerWinCount, dealerWinCount;

        const int BLACKJACK = 21;

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call procedure
            NewGame();
        }

        public frmV2Simplified()
        {
            InitializeComponent();
            // Call procedure
            NewGame();

        }
        private void CreateDeck()
        {

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

        private int DealCard(ref PictureBox aPictureBox)
        {
            // declare variables
            int cardValue = -1;
            
            // generate a random number
            randomNumber = randomNumberGenerator.Next(0, listDeckOfCards.Count() - 1);

            // set the randomNumber from list to the image
            Image card = listDeckOfCards[randomNumber];

            // set the card to a picture from the listBox at a randomIndex
            aPictureBox.Image = listDeckOfCards[randomNumber];

            // get value of card
            cardValue = listDeckOfValues[randomNumber];

            // remove the deck of cards and values from their own list
            listDeckOfCards.RemoveAt(randomNumber);
            listDeckOfValues.RemoveAt(randomNumber);

            // return value
            return cardValue;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // call cards down
            CardsDown();

            // hide label
            picUCard3.Hide();

            // Disable/Enable buttons
            btnStart.Enabled = false;
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            // display two randomly generated cards
            uValue = DealCard(ref this.picUCard);
            uValue2 = DealCard(ref this.picUCard2);

            // set to diff text
            lblPlayerScore.Text = "score";
            lblDealerScore.Text = "score";

        }
        
        private void BtnHit_Click(object sender, EventArgs e)
        {
            // disable button
            btnHit.Enabled = false;

            // Show label
            picUCard3.Show();

            // take reference and display the user value card
            uValue3 = DealCard(ref this.picUCard3);

        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            // Disable button
            btnStay.Enabled = false;
            btnHit.Enabled = false;

            // display dealer cards
            dValue = DealCard(ref this.picDCard);
            dValue2 = DealCard(ref this.picDCard2);
            dValue3 = DealCard(ref this.picDCard3);

            // call function/procedure
            CalculateTotal();
            NewRound();

            // call cards down
            CardsDown();

            // enable start button
            btnStart.Enabled = true;

        }

        private void CalculateTotal()
        {
            // Calculate dealer score
            dealerScore = dValue + dValue2 + dValue3;

            // Convert from int to string
            lblDealerScore.Text = Convert.ToString(dealerScore);

            // calculate user total
            playerScore = uValue + uValue2 + uValue3;

            // Convert from int to string 
            lblPlayerScore.Text = Convert.ToString(playerScore);
        }

        private void DetermineWinner()
        {
           // compare dealer score and player score
           if (playerScore > dealerScore)
           {
                if (playerScore == 21)
                {
                    // Display a message box that it's a blackjack
                    MessageBox.Show("BLACKJACK!");

                    //Call gamesplayed
                    gamesPlayed();

                    // call win count
                    playerWin();
                }
                else
                {
                    if (playerScore > 21)
                    {
                        // display you lose
                        MessageBox.Show("You lose, score is over 21.");

                        // call games played
                        gamesPlayed();

                        // call win count
                        dealerWin();
                    }
                    else
                    {
                        // display you win
                        MessageBox.Show("You win!!");

                        // call games played
                        gamesPlayed();

                        // call win count
                        playerWin();

                    }
                }

           }
           else
           {
                if (playerScore < 21)
                {
                    if (playerScore == dealerScore)
                    {
                        // Display you tie
                        MessageBox.Show("You tied with the dealer!");

                        // call games played
                        gamesPlayed();

                        // call win count
                        dealerWin();
                    }

                }
                else
                {
                    if (playerScore < dealerScore)
                    {
                        // display you lose
                        MessageBox.Show("You lose!");

                        // call games played
                        gamesPlayed();

                        // call win count
                        dealerWin();
                    }
                    
                }
           }
        }

        private void gamesPlayed()
        {
            // Increment the games played
            gamesPlayedCount++;

            // Display games played
            lblTotalGames.Text = "Games Played: " + Convert.ToString(gamesPlayedCount);
        }
        private void NewRound()
        {
            //if there are less than 6 cards, create new deck
            if (listDeckOfCards.Count() <= 6)
            {
                // display messagebox
                MessageBox.Show("You ran out of cards. Deck is reshuffling.");

                // call new game
                NewGame();

            }
            else
            {
                // Call determine winner
                DetermineWinner();
               
            }

        }

        private void NewGame()
        {
            // call functions/procedures
            CreateDeck();
            CardsDown();

            // disable hit and stay
            btnHit.Enabled = false;
            btnStay.Enabled = false;
            btnStart.Enabled = true;

            // Reset global variables
            playerScore = 0;
            dealerScore = 0;
            gamesPlayedCount = 0;
            playerWinCount = 0;
            dealerWinCount = 0;
        }

        private void dealerWin()
        {
            // compare to see if only one person won
            if (playerScore == dealerScore)
            {
                // Increment the dealer win count score and player win count score
                dealerWinCount++;
                playerWinCount++;

                // Display the win count score
                lblDealerWinScore.Text = Convert.ToString(dealerWinCount);
                lblPlayerWinScore.Text = Convert.ToString(playerWinCount);
            }
            else if (playerScore <= 21)
            {
                if (playerScore > dealerScore)
                {
                    // Increment the player win count score
                    playerWinCount++;

                    // display win count score
                    lblPlayerWinScore.Text = Convert.ToString(playerWinCount);
                }
            }
            else
            {
                if (dealerScore > playerScore)
                {
                    // Increment the dealer win count score and player win count score
                    dealerWinCount++;

                    // Display the win count score
                    lblDealerWinScore.Text = Convert.ToString(dealerWinCount);
                }

            }
        }

        private void playerWin()
        {
            // compare to see if only one person won
            if (playerScore == dealerScore)
            {
                // Increment the dealer win count score and player win count score
                dealerWinCount++;
                playerWinCount++;

                // Display the win count score
                lblDealerWinScore.Text = Convert.ToString(dealerWinCount);
                lblPlayerWinScore.Text = Convert.ToString(playerWinCount);
            }
            else if (dealerScore <= 21)
            {
                if (dealerScore > playerScore)
                {
                    // Increment the dealer win count score
                    dealerWinCount++;

                    // display win count score
                    lblDealerWinScore.Text = Convert.ToString(dealerWinCount);
                }

            }
            else
            {
                if ( playerScore > dealerScore)
                {
                    // Increment the player win count score
                    playerWinCount++;

                    // display win count score
                    lblPlayerWinScore.Text = Convert.ToString(playerWinCount);
                }
            }
        }
        private void CardsDown()
        {
            // Set all images to the back of the card
            picUCard.Image = Properties.Resources.Back;
            picUCard2.Image = Properties.Resources.Back;
            picUCard3.Image = Properties.Resources.Back;

            picDCard.Image = Properties.Resources.Back;
            picDCard2.Image = Properties.Resources.Back;
            picDCard3.Image = Properties.Resources.Back;
        }
    }
}
