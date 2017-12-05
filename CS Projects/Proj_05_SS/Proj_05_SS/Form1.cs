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
// Assignment: Project 5
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/25/16
// Description: This form calls on the class SalesReceipt to generate a list of costs.
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_05_SS
{
    public partial class Form1 : Form
    {
        private SalesReceipt sr;
        public Form1()
        {
            //Start the program.
            InitializeComponent();

            //Generate the new class method.
            sr = new SalesReceipt();

            //Make sure that there is a backup plan.
            sr.Reset();
        }

        //Close the application.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Create a messagebox to display information about this project.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nProject 05");
        }

        /// <summary>
        /// This method starts the sales receipt methods.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buy_Click(object sender, EventArgs e)
        {
            double cost = double.Parse(Cost.Text);
            int items = int.Parse(NumberItems.Text);
            sr.SetItems(items);
            sr.SetPrice(cost);
            sr.Invoice();
        }

        //Method to clear the textboxes.
        private void Clear_Click(object sender, EventArgs e)
        {
            Cost.Text = "";
            NumberItems.Text = "";
        }
    }
}
