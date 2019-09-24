/*
 * Created by: Lana ZE
 * Created on: 24-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Area and perimeter of a rectangle
 * This program calculates the area and the perimeter of a rectangle with a given length and width
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

namespace AreaPerLanaZE
{
    public partial class frmAreaPer : Form
    {
        public frmAreaPer()
        {
            InitializeComponent();

            //hide the area and perimeter answer labels until the user hits the calculate button
            this.lblPer.Hide();
            this.lblArea.Hide();
            this.lblPerAnswer.Hide();
            this.lblAreaAnswer.Hide();
        }


        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length, width, area, perimeter;


            // convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            // Calculate the area and the perimeter
            area = width * length;
            perimeter = 2 * (width + length);

            // insert the area and perimeter into their respective variables
            this.lblPerAnswer.Text = Convert.ToString(perimeter) + "  meters";
            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared meters";

            // Show the labels back on the screen when the calculate button is hit
            this.lblPerAnswer.Show();
            this.lblAreaAnswer.Show();
            this.lblPer.Show();
            this.lblArea.Show();
        }

        private void LblPer_Click(object sender, EventArgs e)
        {

        }

        private void FrmAreaPer_Load(object sender, EventArgs e)
        {

        }
    }
}
