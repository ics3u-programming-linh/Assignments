using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aSimplified21LinhH
{
    public partial class frmASimplified21 : Form
    {
        public frmASimplified21()
        {
            InitializeComponent();
            // Call function
            CardsDown();
        }

        private void CardsDown()
        {
            // Create a function that set cards to back cover
            picUCard2.Image = Properties.Resources.Back;
            picUCard.Image = Properties.Resources.Back;
            picUCard3.Image = Properties.Resources.Back;

            picDCard.Image = Properties.Resources.Back;
            picDCard2.Image = Properties.Resources.Back;
            picDCard3.Image = Properties.Resources.Back;
        }


        // goal is to display 2 cards
        private void BtnHit_Click(object sender, EventArgs e)
        {
            // Call DealCard Function
        }

        private void BtnStand_Click(object sender, EventArgs e)
        {
            // Disable hit and stay button

            // If user total is less than 17....
            // Call CalculateTotal
            // Otherwise... Call DealCard Function
        }

    }
}
