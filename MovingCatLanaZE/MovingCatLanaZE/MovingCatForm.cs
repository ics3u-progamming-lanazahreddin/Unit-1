/*
 * Created by: Lana ZE
 * Created on: 16-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Moving Cat
 * This program will display a different version of a cat each time you press on
 * the cat button
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

namespace MovingCatLanaZE
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
            // this will hide the cats until the user press on one of the cats
            this.picCat1.Hide();
            this.picCat2.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this will close the program when the user clickes on Exit
            this.Close();
        }

        private void Cat1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat1.Image = Properties.Resources.cat1;
            this.picCat1.Show();
            this.picCat2.Hide();
        }

        private void Cat2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat2.Image = Properties.Resources.cat2;
            this.picCat2.Show();
            this.picCat1.Hide();
        }

        private void PicCat2_Click(object sender, EventArgs e)
        {

        }
    }
}
