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
// Assignment: Lab 17
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004
// Date Written: 3/3/16
// Description:  This program displays a message box that tells you what
// shipping method you chose.
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Lab17_SS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This closes the program.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This gives information about the program.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nLab 17");
        }

        //Button method that controls if statements about the radio buttons.
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Selected Standard Shipping");

            if (radioButton2.Checked)
                MessageBox.Show("Selected Express Shipping");

            if (radioButton3.Checked)
                MessageBox.Show("Selected Same-Day Shipping");
        }
    }
}

