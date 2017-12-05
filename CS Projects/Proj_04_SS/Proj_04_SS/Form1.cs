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
// Assignment: Project 4
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/11/16 
// Description: This program calculates the hypotenuse of a non square triangle based on
//two sides given and the angle. It also calculates the other two angles.
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_04_SS
{
    public partial class Project4 : Form
    {
        //Declare Constants.
        const int TWO = 2;
        const int TRIANGLE = 180;


        // Purpose: To find the hypotenuse using pythagorams therom with cos.
        // Parameters: Side 1, Side 2, degree 1.
        // Returns: The hypotenuse of the triangle.
        // Pre-conditions: Sides 1  and 2 must be known along with degree 1.
        // Post-conditions: None.
        //Create a method that calculates the hyotenuse using c^2=a^2+b^2-2abCos()

        static double CalcHypotenuse(double sideA, double sideB, double degreeC)
        {
            //Square both sides.
            double squareSideA = sideA * sideA;
            double squareSideB = sideB * sideB;

            //Add the two squares.
            double sumSquares = squareSideA + squareSideB;

            //create the cos.
            double radianC = degreeC * Math.PI / TRIANGLE;
            double cosAngle = TWO * sideA * sideB * Math.Cos(radianC);
            double subDegree = sumSquares - cosAngle;
            double squareDegree = Math.Sqrt(subDegree);
            return squareDegree;
        }
        // To find angle A.
        // Parameters: degree C, sideA, sideB, sideC.
        // Returns: The angle of A.
        // Pre-conditions: degree C, sideA, sideB,and sideC must be known.
        // Post-conditions: None.
        //Create a method that calculates the angle of A.

        static double CalcAngleA(double degreeC, double sideA, double sideB, double sideC)
        {
            //Square the sides.
            double squareSideA = sideA * sideA;
            double squareSideB = sideB * sideB;
            double squareSideC = sideC * sideC;

            //Put the sides through the triangle formula cos B.
            double dividenB = squareSideC + squareSideA - squareSideB;
            double diviserB = TWO * sideA * sideC;
            double angleB = dividenB / diviserB;
            double degB = Math.Acos(angleB);
            double radianB = degB * TRIANGLE / Math.PI;
            
            return radianB;

        }
        // Purpose: To find angle B.
        // Parameters: degree B and degree C.
        // Returns: The degree of B.
        // Pre-conditions: degree B and degree C must be known.
        // Post-conditions: None.
        //Create a method that calculates the angle of B.

        static double CalcAngleB(double degreeC, double degreeB)
        {
            //Find a though subtraction of 180 and b.
            double angleA = TRIANGLE - degreeC - degreeB;
            return angleA;

        }

        public Project4()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ShaneSoderstrom\nCS 1400\nProject 04");
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Receive sides A, B, and the angle.
            double sideA = double.Parse(boxA.Text);
            double sideB = double.Parse(boxB.Text);
            double degreeC = double.Parse(angleC.Text);

            //Put it through the method Hypotenuse.
            double sideC = CalcHypotenuse(sideA, sideB, degreeC);

            //Return the result of side c.
            boxC.Text = $"{sideC:f2}";

            //Put angle a through both the methods to receive angles b and c.
            double degreeB = CalcAngleA(degreeC, sideA, sideB, sideC);
            double degreeA = CalcAngleB(degreeC, degreeB);

            //Return angles b and c.
            angleB.Text = $"{degreeB:f2}";
            angleA.Text = $"{degreeA:f2}";



        }
    }
}
