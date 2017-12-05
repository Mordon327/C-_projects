using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Author: Shane Soderstrom
// Assignment: Project #2
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004
// Date Written: 1/30/16 
// Description: This program calculates The amount that each pirate receives. 
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_02_SS
{
    public partial class Project2 : Form
    {
        

        //Declare Constants
        const int JACK_SHARE = 12;
        const int FIRSTMATE_SHARE = 8;
        const int HALF = 2;
        const int HUNDRED = 100;
        const int PARTYGOLD = 3;
        const int TWO = 2;


        public Project2()
        {
            InitializeComponent();
        }

        //Exit button.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //About message box.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nProject 02");
        }



        //Receive characters from the user and store as ints.

            //Make a button that lets the program run.
        private void button1_Click(object sender, EventArgs e)
        {
            int gold = int.Parse(NumberofGold.Text);
            int pirates = int.Parse(NumberofPirates.Text);

            //Find available gold.
            int partygoldtotal = PARTYGOLD * (pirates - TWO);
            int newgoldtotal = gold - partygoldtotal;

            //find jack and firstmates first cut of the profit.
            int jackpaycheck = newgoldtotal * JACK_SHARE / HUNDRED;
            int firstmatepaycheck = (newgoldtotal - jackpaycheck) * FIRSTMATE_SHARE / HUNDRED;

            //Pirates bounty.
            int pirategold = newgoldtotal - jackpaycheck - firstmatepaycheck;
            int per_pirate = pirategold / pirates;

            //Output the results as ints.
            JackBox.Text = $"{per_pirate + jackpaycheck:d}";
            FirstMateBox.Text = $"{per_pirate + firstmatepaycheck:d}";
            CrewBox.Text = $"{per_pirate:d}";

            //PBABox.Text = $"{pirategold % pirates}";
            PBABox.Text = $"{gold - partygoldtotal - jackpaycheck - firstmatepaycheck - (per_pirate * pirates)}";


        }



    }
}
