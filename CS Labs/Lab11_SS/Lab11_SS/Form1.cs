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
// Assignment: 11
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/10/16
// Description: Creating a method.
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy. 


namespace Lab11_SS
{

    public partial class Form1 : Form
    {
        static double CalcHypotenuse(double side1, double side2)
        {
            // Purpose: The purpose is to find the hypotenuse of a triangle.
            // Parameters: Side A, Side B.
            // Returns: Side C, the hypotenuse.
            // Pre-conditions: Must have sideA and sideB.
            // None.

            //Square both numbers.
            double squareOne = side1 * side1;
            double squareTwo = side2 * side2;
            //Add the numbers together.
            double sumSquares = squareOne + squareTwo;
            //Find the square root of the number.
            double sqrtSum = Math.Sqrt(sumSquares);
            //Return the number to the user.
            return sqrtSum;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Receive sides a and b from the user.
            double sideA = double.Parse(Side1.Text);
            double sideB = double.Parse(Side2.Text);

            //Use the method for calculating the hypotenuse.
            double sideC = CalcHypotenuse(sideA, sideB);

            //Return the information back to the user.
            Side3.Text = $"{sideC:F}";


        }

        //Close the application.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //About box.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nLab 11");
        }
    }
}


