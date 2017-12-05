using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: Shane Soderstrom
// Assignment: Lab 15
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/25/16
// Description: This class holds methods that calculate the hypotenuse of a right triangle
// And it's area. 
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.


namespace Lab15_SS
{
    class Domain
    {
        //Declare Variables
        double sideA;
        double sideB;
        const int TWO = 2;

        //Set each value to 0.
        public void Reset()
        {
            sideA = 0;
            sideB = 0;
            
        }
        /// <summary>
        /// Sets the number for sideA.
        /// </summary>
        /// <param name="value">Takes a double.</param>
        public void SetSideA(double value)
        {
            sideA = value;
        }

        /// <summary>
        /// Sets the number for sideB.
        /// </summary>
        /// <param name="value">Takes a double.</param>
        public void SetSideB(double value)
        {
            sideB = value;
        }

        /// <summary>
        /// Finds the hypotenuse from two sides.
        /// </summary>
        /// <returns>A doube.</returns>
        public double SideC()
        {
            double squareA = sideA * sideA;
            double squareB = sideB * sideB;
            double hypotenuse = Math.Sqrt(squareB + squareA);
            return hypotenuse;
        }


        /// <summary>
        /// Finds the area based on 2 sides.
        /// </summary>
        /// <returns>A double.</returns>
        public double Inside()
        {
            double area = sideB * sideA / TWO;
            return area;
        }

    }
}
