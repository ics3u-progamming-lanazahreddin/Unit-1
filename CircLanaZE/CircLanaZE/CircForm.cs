/*
 * Created by: Lana ZE
 * Created on: 19-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Circumference of a  circle
 * This program will calculate the circumference of a cirlce given the radius.
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

namespace CircLanaZE
{
    public partial class frmCirc : Form
    {
        public frmCirc()
        {
            InitializeComponent();
            this.lblCirc.Hide();
        }

        private void LblInstructions_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this closes the program when u click on file, exit
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double radius, circumference;

            // declare the text from the text box into a string
            radius = double.Parse(txtRadius.Text);

            // calculate the circumference of the circle
            circumference = 2 * Math.PI * radius;

            // isnert the circumference of the circle into the answer label
            this.lblCircAnswer.Text = Convert.ToString(circumference) + "meters.";

            // show the instruction label back on the screen 
            this.lblCirc.Show();
        }
    }
}
