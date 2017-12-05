using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// Author: Shane Soderstrom
// Assignment: Lab 22
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 3/28/16
// Description: Uses an array tostore values and then returns the sum.
 
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
            const int SIZE = 10;

            //Create and initialize a new array.
            int[] examScores = new int[SIZE];

            //Give instructions.
            WriteLine("Please enter 10 numbers, each followed by pressing enter.");

            //Create a loop that inputs scores to be saved.
            for (int i = 0; i < SIZE; i++)
            {
                //call the array and use parse to store numbers.
                examScores[i] = int.Parse(ReadLine());
            }

            //Return the sum of the numbers stored in the array.
            WriteLine($"The sum of the elements in the array is:{SumArray(examScores)}");
            ReadLine();

        }

        /// <summary>
        /// Method that sums up the numbers inputed into the array.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>The sum of arrays.</returns>
        static int SumArray(int[] numbers)
        {
            int sum = 0;
            foreach (int value in numbers)
            {
                sum += value;
            }

            return sum;
        }
    }
}
