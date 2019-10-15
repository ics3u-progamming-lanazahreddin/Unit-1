/*
 * Created by: Lana ZE
 * Created on: September 14, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pseudocode
 * This program calculates the cost of a pizza when given the diameter of the pizza (in inches)
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

namespace PizzaCostLanaZE
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            // hide the cost label
            lblCost.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Variables
            double costBeforeTax, costAfterTax;
            int diameter;

            // convert the diameter into a string
            diameter = Convert.ToInt32(txtDiameter.Text);

            // calculation for the pizza cost after tax
            costBeforeTax = 0.75 + 0.99 + 0.5 * diameter;
            costAfterTax = costBeforeTax * 1.13;
            lblCost.Text = "$" + Convert.ToString(Math.Round(costAfterTax , 2));
            lblCost.Show();
        }
    }
}
