/*
 * Created by: Linh Ho
 * Created on: October 31st, 2019
 * Created for: ICS3U Programming
 * Assignment #5b - Simplified 21
 * This program generates random cards for the user and computer. 
 * User wins only if they score 21 or has a higher score than the computer.
 * Otherwise, they lose or tie with the computer depending on the situation. 
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

namespace Simplified21LinhHo
{
    public partial class frmSimplified21 : Form
    {
        // declare variables and constants
        int playerScore;
        int computerScore;
        const int MIN_NUM = 1;
        const int MAX_NUM = 11;
        const int BLACKJACK = 21;
        public frmSimplified21()
        {
            InitializeComponent();

            // Hide labels, buttons, and etc.
            grbScore.Hide();
            grbHitOrStand.Hide();
            lblCompCard1.Hide();
            lblPlayerCard1.Hide();
            lblPlayerCard2.Hide();
            lblPlayerCard3.Hide();
            lblCompCard2.Hide();
            lblCompCard3.Hide();
            lblCompCard4.Hide();
            btnRestart.Hide();
            
            // Call New Game procedure
            NewGame();
        }

        public void NewGame()
        {
            // Hide labels, groups and buttons
            grbScore.Hide();
            grbHitOrStand.Hide();
            lblCompCard1.Hide();
            lblPlayerCard1.Hide();
            lblPlayerCard2.Hide();
            lblPlayerCard3.Hide();
            lblCompCard2.Hide();
            lblCompCard3.Hide();
            lblCompCard4.Hide();
            btnRestart.Hide();

            // Show labels, buttons and etc.
            grbMain.Show();

            // Enable buttons
            btnHit.Enabled = true;
            btnStand.Enabled = true;
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }

        private void MniNewGame_Click(object sender, EventArgs e)
        {
            // Restart game when it's clicked
            NewGame();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // hide labels, buttons and etc.
            grbMain.Hide();
            lblPlayerCard3.Hide();
            lblCompCard2.Hide();
            lblCompCard3.Hide();
            lblCompCard4.Hide();

            // Show labels, buttons and etc
            grbHitOrStand.Show();
            grbScore.Show();
            lblPlayerCard1.Show();
            lblPlayerCard2.Show();
            lblCompCard1.Show();

            // declare variables
            int randomPlayerCard;
            int randomPlayerCardTwo;
            int randomComputerCard;
            Random randomNumberGenerator = new Random();

            // get the random number for the first random player card
            randomPlayerCard = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // get the second random number player card
            randomPlayerCardTwo = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // get the first random number card generated for computer
            randomComputerCard = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // Assign random player/computer number to the labels
            lblPlayerCard1.Text = Convert.ToString(randomPlayerCard);
            lblPlayerCard2.Text = Convert.ToString(randomPlayerCardTwo);
            lblCompCard1.Text = Convert.ToString(randomComputerCard);

            // Calculate the dealer/user score
            playerScore = randomPlayerCard + randomPlayerCardTwo;
            computerScore = randomComputerCard;

            // Convert from int to string
            lblPlayerScore.Text = Convert.ToString(playerScore);
            lblDealerScore.Text = Convert.ToString(computerScore);

        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            // Show labels
            lblPlayerCard3.Show();

            // declare variables
            int randomPlayerCardThree;
            Random randomNumberGenerator = new Random();

            // get the third random card for player
            randomPlayerCardThree = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // Calculate the user score
            playerScore = playerScore + randomPlayerCardThree;

            // Assign random player card number to the labels
            lblPlayerCard3.Text = Convert.ToString(randomPlayerCardThree);
            lblPlayerScore.Text = Convert.ToString(playerScore);

            // If card is over 21, 
            if (playerScore > 21)
            {
                // Display a message box indicating that user lost and disable buttons
                MessageBox.Show("You lose. You went over 21!");
                btnHit.Enabled = false;
                btnStand.Enabled = false;

                // Display restart button
                btnRestart.Show();
            }
            else if (playerScore == BLACKJACK)
            {
                // Display a message box indicating that user won and disable buttons
                MessageBox.Show("You win, blackjack!");
                btnHit.Enabled = false;
                btnStand.Enabled = false;

                // Display restart button
                btnRestart.Show();
            }
            else
            {
                // Enable buttons
                btnHit.Enabled = true;
                btnStand.Enabled = true;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            // Disable buttons
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            // Show labels
            lblCompCard2.Show();

            // Hide labels
            lblCompCard3.Hide();
            lblCompCard4.Hide();

            // declare variables
            int randomCompCardTwo;
            int randomCompCardThree;
            int randomCompCardFour;
            Random randomNumberGenerator = new Random();

            // get random number cards for computer
            randomCompCardTwo = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            
            // Calculate the computer score
            computerScore = computerScore + randomCompCardTwo;

            // Assign random computer card number to the labels
            lblCompCard2.Text = Convert.ToString(randomCompCardTwo);
            lblDealerScore.Text = Convert.ToString(computerScore);

            // Check to see if computer score is less than 17
            if (computerScore < 17)
            {
                // show label
                lblCompCard3.Show();

                // get random number cards for computer
                randomCompCardThree = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

                // Calculate the computer score
                computerScore = computerScore + randomCompCardThree;

                // Display score and label
                lblCompCard3.Text = Convert.ToString(randomCompCardThree);
                lblDealerScore.Text = Convert.ToString(computerScore);

                // Check again to see if computer score is less than 17
                if (computerScore <= 17)
                {
                    // Show label
                    lblCompCard4.Show();

                    // Generate a random number for the fourth card for computer
                    randomCompCardFour = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

                    // Calculate the computer score
                    computerScore = computerScore + randomCompCardFour;

                    // Display score and label
                    lblCompCard4.Text = Convert.ToString(randomCompCardFour);
                    lblDealerScore.Text = Convert.ToString(computerScore);
                }
                
            }

            // Compare computer's score and user's score
            if (computerScore > 21 && playerScore > 21)
            {
                // Display a message box that the user lost.
                MessageBox.Show("You and the dealer went over 21. You lose.");

                // Display restart button
                btnRestart.Show();
            }
            else if (computerScore > 21)
            {
                // Display a message box that the user has won.
                MessageBox.Show("The dealer busted. You win!");

                // Display restart button
                btnRestart.Show();
            }
            else if (playerScore > 21)
            {
                // Display a message box that the user has lost.
                MessageBox.Show("You busted. The dealer wins!");

                // Display restart button
                btnRestart.Show();
            }
            else if (computerScore > playerScore)
            {
                // Display a message box that the user has lost.
                MessageBox.Show("Dealer scored higher. You lose.");

                // Display restart button
                btnRestart.Show();
            }
            else if (playerScore > computerScore)
            {
                // Display a message box that the user has won
                MessageBox.Show("You have won! Congratulations!");

                // Display restart button
                btnRestart.Show();
            }
            else if (computerScore == BLACKJACK)
            {
                // Display a message box that the computer has won
                MessageBox.Show("Dealer got 21, blackjack. Try again!");

                // Display restart button
                btnRestart.Show();
            }
            else if (playerScore == BLACKJACK)
            {
                // Display a message box that the user has won
                MessageBox.Show("You have won! Blackjack!");

                // Display restart button
                btnRestart.Show();
            }
            else
            {
                // Display a message box that the user has tied with the dealer.
                MessageBox.Show("It's a tie!");

                // Display restart button
                btnRestart.Show();
            }

        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            NewGame();
        }

    }
}
