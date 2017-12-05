using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// Author: Shane Soderstrom
// Assignment: 10
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/9/16
// Description: Creating a method.
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy. 

namespace Lab_10_SS
{
    class Program
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
        static void Main(string[] args)
        {
            Console.WriteLine  ("Enter side a and side b.");
            //Declare constants.
            //Retreive side A and B from the user.
            double sideA = double.Parse(ReadLine());
            double sideB = double.Parse(ReadLine());
            double sideC = CalcHypotenuse(sideA, sideB);
            //WriteLine($"Hello {}. You are almost {myAge} years old and you have {money}.");

            Console.WriteLine($"The hypotenuse is {sideC}.");
            Console.WriteLine("Press any key to continue.");
            ReadKey(true);
            }
         }

}
