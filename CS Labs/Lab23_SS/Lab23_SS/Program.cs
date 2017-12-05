using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// Author: Shane Soderstrom
// Assignment: Lab 23
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 3/31/16
// Description: Uses an array to store values and then returns the multiplication.

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Lab22_SS
{
    class Program
    {


        static void Main(string[] args)
        {
            //Declare constants to avoid magic numbers.
            const int SIZE = 100;
            int count = 0;

            //Create and initialize a new array.
            int[] examScores = new int[SIZE];

            //Give instructions.
            WriteLine("Please enter up to 100 numbers, each followed by pressing enter.");


            //Create a loop that inputs scores to be saved.
            for (int i = 0; i < SIZE; i++)
            {
                //call the array and use parse to store numbers.
                int value = int.Parse(ReadLine());

                //for every value entered that is not zero, it will enter the array.
                if (value != 0)
                {
                    examScores[i] = value;
                    count++;
                }

                else
                {
                    //sets the size of i to the max so it will break out of loop.
                    i = SIZE;

                }

            }


            //Return the values through a writeline.
            WriteLine($"The product of the elements in the array is:{ProdArray(examScores, count)}");
            ReadLine();

        }


        /// <summary>
        /// Method that multiplies up the numbers inputed into the array.
        /// </summary>
        /// <param name="numbers">nmbers and count</param>
        /// <returns>The multiplication of arrays.</returns>
        static int ProdArray(int[] numbers, int count)
        {
            int prod = 1;
            for (int i = 0; i < count; i++)
            {
                prod *= numbers[i];
            }

            return prod;
        }
    }
}
