/*
 * Created by: Linh Ho 
 * Created on: September 19, 2019
 * Created for: ICS3U Programming
 * Major Assignment - #2 - Falling Objects
 * This program calculates the input of the users time 
 * to get the height of the object thrown at 100m on a cliff
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

namespace FallingObjectsLinhHo
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();

            // Hiding objects 
            lblQuestion.Visible = false;
            txtTime.Visible = false;
            btnCalculate.Visible = false;
            lblAnswer.Visible = false;
            lblHeight.Visible = false;

        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {

        }

        private void LblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            // Make the text and images invisible 
            lblMadeBy.Visible = false;
            picCliff.Visible = false;
            lblTitle.Visible = false;
            btnNextPage.Visible = false;

            // Make the text answer and button visible
            txtTime.Visible = true;
            btnCalculate.Visible = true;
            lblQuestion.Visible = true;

            // Adjust the labels
            lblQuestion.SendToBack();
            txtTime.BringToFront();

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Declare local variables
            double time, answer;

            // Declare constant
            const double GRAVITY = 9.81;

            // Make image and labels visible
            picCliff.Visible = true;
            lblAnswer.Visible = true;
            lblHeight.Visible = true;

            // Change the background image to another cliff image
            picCliff.Image = Properties.Resources.cliff;

            // Convert the string from each text box to a double
            time = double.Parse(txtTime.Text);
            
            // Does not allow to input a negative number 
            if (time < 0)
            {
                // Displays a text
                this.lblHeight.Text = "Input a positive number.";
            }
            else
            {

                // Calculate the time of the falling object
                answer = 100 - (0.5 * GRAVITY * Math.Pow(time, 2));

                // Rounding the answer to two decimals
                answer = answer * 100;
                answer = Math.Round(answer);
                answer = answer / 100;

                if (answer > 0)
                {
                    // Change the text
                    this.lblHeight.Text = Convert.ToString(answer) + "m";
                }
                else
                {
                    // Display text that it already reached the ground
                    this.lblHeight.Text = "It already hit the ground!";
                }

            }
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
