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
            
            // Make the question and images visible
            lblQuestion.Visible = true;
            lblQuestion2.Visible = true;
            imgCliff2.Visible = true;

            // Adjust the labels and text
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
            // Make the labels visible
            lblAnswer.Visible = true;
            lblHeight.Visible = true;

            // Create an error when nothing is entered
            if (txtTime.Text == "")
            {
                lblHeight.Text = "Error, please enter a valid value";

            }
            else
            {
                // Convert from string to a double
                double time = double.Parse(txtTime.Text);

                // Formula for falling object
                double Answer = 100 - (0.5 * 9.81 * Math.Pow(time, 2));

                // Round the answer
                Answer = Answer * 100;
                Answer = Math.Round(Answer);
                Answer = Answer / 100;

                if (Answer > 0)
                {
                    // Change the text
                    lblHeight.Text = Convert.ToString(Answer) + "m";
                }
                else
                {
                    // Displays reaching the ground already
                    lblHeight.Text = "It already hit the ground!";
                }

                // Does not allow to input a negative number 
                if (time < 0)
                {
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
    }
}
