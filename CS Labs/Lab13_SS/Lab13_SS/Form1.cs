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
// Assignment: Lab 13
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/18/2016
// Description: This is a car wash token generator. 
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Lab13_SS
{
    public partial class Form1 : Form
    {
        // a class level reference to a token machine
        private TokenMachine tm;

        public Form1()
        {
            //Initializes the program and inputs the starting values.
            InitializeComponent();
            //Makes a token machine.
            tm = new TokenMachine();
            tm.Reset();
            //Calls upon the tm methods and declares starting values.
            int plusQuarter = tm.CountQuarters();
            QuarterBox.Text = $"{plusQuarter}";
            int minusToken = tm.CountTokens();
            TokenBox.Text = $"{minusToken}";
        }

        //On click button that adds and subtracts quarters and tokens.
        private void GetToken_Click(object sender, EventArgs e)
        {
            //Calls on the get token method.
            tm.GetToken();
            int plusQuarter = tm.CountQuarters();
            QuarterBox.Text = $"{plusQuarter}";
            int minusToken = tm.CountTokens();
            TokenBox.Text = $"{minusToken}";
        }

        //Closes the program.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Info box.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nLab 13");
        }

        //Resets the starting numbers.
        private void Refill_Click(object sender, EventArgs e)
        {
            tm.Reset();
            int plusQuarter = tm.CountQuarters();
            QuarterBox.Text = $"{plusQuarter}";
            int minusToken = tm.CountTokens();
            TokenBox.Text = $"{minusToken}";
        }
    }
}
