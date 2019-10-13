﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderLinhH
{
    public partial class frmPizzaOrder : Form
    {
        // Declare constants and variables
        const double MEDIUM_PIZZA = 6.99;
        const double LARGE_PIZZA = 9.99;
        const double XTRALARGE_PIZZA = 12.99;
        const double HST = 0.13;
        const double GST = 0.05;
        const double ONE_TOPPING = 0.75;
        const double TWO_TOPPINGS = 1.35;
        const double THREE_TOPPINGS = 2.15;
        const double FOUR_TOPPINGS = 2.75;
        const double ONE_SODA = 1.00;
        const double NO_SODA = 0;
        const double YES_DELIVERY = 3.00;
        const double NO_DELIVERY = 0;

        public frmPizzaOrder()
        {
            InitializeComponent();

            // send pizza background to the back 
            this.picPizza.SendToBack();

            // Hide groups, labels and buttons
            grbSize.Hide();
            lblWelcome.Hide();
            grbSoda.Hide();
            grbToppings.Hide();
            grbDelivery.Hide();
            btnConfirm.Hide();
            grbTotal.Hide();
            grbTax.Hide();
            btnRefresh.Hide();
            picPizzaNext.Hide();
            picConfirm.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Hide the images and labels
            this.picPizza.Hide();
            this.btnStart.Hide();
            this.lblCompanyName.Hide();
            this.picConfirm.Hide();

            // Show images, labels and buttons
            this.grbSize.Show();
            this.lblWelcome.Show();
            this.grbToppings.Show();
            this.grbSoda.Show();
            this.grbDelivery.Show();
            this.btnConfirm.Show();
            grbTax.Show();
            picPizzaNext.Show();

            

            // Change the text
            lblWelcome.Text = "Welcome to Von Dough's Pizza!";

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            // declare the variables
            double size, toppings, soda, delivery, subtotal, tax, totalCost;

            // Display the groupbox and buttons
            grbTotal.Show();
            btnRefresh.Show();
            picConfirm.Show(); 

            // Hide groupbox, buttons and images
            grbSize.Hide();
            grbToppings.Hide();
            grbSoda.Hide();
            grbDelivery.Hide();
            grbTax.Hide();
            btnConfirm.Hide();
            picPizzaNext.Hide();

            // Change the text
            lblWelcome.Text = "Thanks for ordering at Von Dough's pizza!";

            // User chooses what size of pizza they want
            if (nudSize.Value == 1)
            {
                size = MEDIUM_PIZZA;
            }
            else if (nudSize.Value == 2)
            {
                size = LARGE_PIZZA;
            }
            else
            {
                size = XTRALARGE_PIZZA;
            }

            // User chooses how many toppings that they want
            if (nudToppings.Value == 1)
            {
                toppings = ONE_TOPPING;
            } 
            else if (nudToppings.Value == 2)
            {
                toppings = TWO_TOPPINGS;
            }
            else if (nudToppings.Value == 3)
            {
                toppings = THREE_TOPPINGS;
            }
            else
            {
                toppings = FOUR_TOPPINGS;
            }

            // User chooses if they want a soda or not
            if (nudSoda.Value == 0)
            {
                soda = NO_SODA;
            }
            else
            {
                soda = ONE_SODA;
            }

            // User chooses if they want delivery or not
            if (nudDelivery.Value == 0)
            {
                delivery = NO_DELIVERY;
            }
            else
            {
                delivery = YES_DELIVERY;
            }

            // Calculate and display the subtotal of pizza
            subtotal = size + toppings + soda + delivery;

            lblSubtotalAnswer.Text = String.Format("${0:0.00}", subtotal);

            // User chooses which taxes they use
            if (nudTax.Value == 0)
            {
                tax = HST; 
            }
            else
            {
                tax = GST;
            }

            // Calculate and display the tax of subtotal
            tax = tax * subtotal;
            
            lblTaxAnswer.Text = String.Format("${0:0.00}", tax);

            // Calculate and display the final total
            totalCost = tax + subtotal;

            lblTotalAnswer.Text = String.Format("${0:0.00}", totalCost);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

            // Hide the labels, buttons and groupbox
            grbTotal.Hide();
            btnRefresh.Hide();
            picConfirm.Hide();

            // Show images, labels and buttons
            this.grbSize.Show();
            this.grbToppings.Show();
            this.grbSoda.Show();
            this.grbDelivery.Show();
            this.btnConfirm.Show();
            this.grbTax.Show();
            this.lblWelcome.Show();
            this.picPizzaNext.Show();

            // Change the text
            lblWelcome.Text = "Welcome to Von Dough's Pizza!";

        }
    }
}
