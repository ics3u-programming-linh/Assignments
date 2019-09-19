/*
 * Created by: Linh Ho
 * Created on: September 19th, 2019
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program... calculates the time after an object falls off of a 100m cliff
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

namespace FallingObjectsLinhH
{
    public partial class frmFallingObjects : Form
    {


        public frmFallingObjects()
        {
            InitializeComponent();

            // Hide Objects
            lblQuestion.Visible = false;
            lblQuestion2.Visible = false;
            txtTime.Visible = false;
            btnCalculate.Visible = false;
            lblAnswer.Visible = false;
            lblHeight.Visible = false;
            imgCliff2.Visible = false;

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LblMadeBy_Click(object sender, EventArgs e)
        {

        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {

            // Make the text and images invisible 
            lblMadeBy.Visible = false;
            imgCliff.Visible = false;
            lblTitle.Visible = false;
            btnNextPage.Visible = false;
            
            // Make the question and image visible
            lblQuestion.Visible = true;
            lblQuestion2.Visible = true;
            imgCliff2.Visible = true;

            // Adjust the labels
            lblQuestion.SendToBack();
            txtTime.BringToFront();

            // Make the text answer and button visible
            txtTime.Visible = true;
            btnCalculate.Visible = true;
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }

        private void FrmFallingObjects_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblQuestion2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double time, answer;

            // Create an error when nothing is entered
            if (txtTime.Text == "")
            {
                lblHeight.Text = "Error, please enter a valid value";

            }

            // Make the labels visible
            lblAnswer.Visible = true;
            lblHeight.Visible = true;

            // Convert from string to a double
            time = double.Parse(txtTime.Text);

            {
                
                // Formula for falling object
                answer = 100 - (0.5 * 9.81 * Math.Pow(time, 2));

                // Round the answer
                answer = answer * 100;
                answer = Math.Round(answer);
                answer = answer / 100;

                if (answer > 0)
                {
                    // Change the text
                    lblHeight.Text = Convert.ToString(answer) + "m";
                }
                else
                {
                    // Display text that it already reached the ground
                    lblHeight.Text = "It already hit the ground!";
                }

                // Does not allow to input a negative number 
                if (time < 0)
                {
                    // Displays a text
                    lblHeight.Text = "Input a positive number.";
                }

            }

        }

        
        private void TxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void LblHeight_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void ExtraStepToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
