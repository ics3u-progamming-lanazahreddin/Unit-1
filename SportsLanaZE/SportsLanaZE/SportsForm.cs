/*
 * Created by: Lana ZE
 * Created on: 14-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Sports
 * This program displays 4 sports with my favourite player of each sport
 * and a picture each the player in the background
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

namespace SportsLanaZE
{
    public partial class frmSpots : Form
    {
        public frmSpots()
        {
            // this changes the background image of the entire form
            this.BackgroundImage = Properties.Resources.sports;
            InitializeComponent();
        }

        private void MniSports_Click(object sender, EventArgs e)
        {
            //this label displays sports when you click on it with a background image
            this.lblSportType.Text = "Sports :)";
            this.lblFavPlayer.Text = "";
        }

        private void FrmSpots_Load(object sender, EventArgs e)
        {

        }

        private void SoccerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this label displays my fav soccer player with an image of him
            // //when you click on it
            this.BackgroundImage = Properties.Resources.soccerplayer;
            this.lblSportType.Text = "Soccer";
            this.lblFavPlayer.Text = "Christiano ronaldo";
        }

       

        private void MniTennis_Click(object sender, EventArgs e)
        {
            //this label displays my fav tennis player with a picture of her
            // //when you click on it
            this.BackgroundImage = Properties.Resources.tennisplayer;
            this.lblSportType.Text = "Tennis";
            this.lblFavPlayer.Text = "Bianca Andreescu";
        }

        private void MniBasketball_Click(object sender, EventArgs e)
        {
            //this displays my fav basketball player and a picture of him 
            //when you click on it
            this.BackgroundImage = Properties.Resources.basketballplayer;
            this.lblSportType.Text = "Basketball";
            this.lblFavPlayer.Text = "LeBron James";
        }

        private void MniFootball_Click(object sender, EventArgs e)
        {
            //this label displays my fav football player with a picture of him
            //when u click on it
            this.BackgroundImage = Properties.Resources.footballplayer;
            this.lblSportType.Text = "Football";
            this.lblFavPlayer.Text = "Odell Beckham Jr";
        }
    }
}
