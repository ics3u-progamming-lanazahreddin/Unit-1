﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsLanaZE
{
    public partial class frmSpots : Form
    {
        public frmSpots()
        {
            InitializeComponent();
        }

        private void SoccerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lblSportType.Text = "Soccer";
            this.lblFavPlayer.Text = "Christiano ronaldo";
        }

        private void MniSports_Click(object sender, EventArgs e)
        {
            this.lblSportType.Text = "Sports :)";
            this.lblFavPlayer.Text = "";
        }

        private void FrmSpots_Load(object sender, EventArgs e)
        {

        }

        private void MniTennis_Click(object sender, EventArgs e)
        {
            
        }
    }
}