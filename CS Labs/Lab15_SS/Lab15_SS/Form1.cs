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
// Assignment: Lab 15
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/25/16
// Description: This form calls on the class Domain in order to calculate
// The hypotenuse of a right triangle and its area.
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Lab15_SS
{
    public partial class Form1 : Form
    {
        private Domain dm;
        public Form1()
        {
            //Initialize the program.
            InitializeComponent();

            //Call on the class Domain.
            dm = new Domain();
            dm.Reset();

        }
        /// <summary>
        /// Calls on the method to close the application.
        /// </summary>
        /// <param name="sender">Object handler</param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Displays project information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Object handler</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nLab 15");
        }


        /// <summary>
        /// Calls on the methods from the Domain class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Domain class.</param>
        private void sideC_Click(object sender, EventArgs e)
        {
            double firstSide = double.Parse(SideA.Text);
            double secondSide = double.Parse(SideB.Text);
            dm.SetSideA(firstSide);
            dm.SetSideB(secondSide);
            double hypotenuse = dm.SideC();
            Hypotenuse.Text = $"{hypotenuse:F2}";
            double newArea = dm.Inside();
            Area.Text = $"{newArea:F2}";

        }

        private void Area_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Clears the text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Object handler</param>
        private void Reset_Click(object sender, EventArgs e)
        {
            SideA.Text = "";
            SideB.Text = "";
            Hypotenuse.Text = "";
            Area.Text = "";
        }
    }
}
