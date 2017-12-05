using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: Shane Soderstrom
// Assignment: Lab 21
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 3/24/16
// Description:  Uses the greedy algorithm to identify how many coins of specific
// types are used in a given number.
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
namespace Lab21_SS
{
    class Program
    {
        // some  class level constants
        const int HALVES = 50;
        const int QUARTERS = 25;
        const int DIMES = 10;
        const int NICKELS = 5;
        const int PENNIES = 1;

        static void Main()
        {
            int money;  // the value we want to count change for

            Console.WriteLine("I will make change for you.");
            Console.Write("Enter in an amount between 1 and 99: ");
            money = int.Parse(Console.ReadLine());

            Console.WriteLine("For {0} you get:", money);

            Console.WriteLine("{0} halves", ComputeChange(ref money, HALVES));
            Console.WriteLine("{0} quarters", ComputeChange(ref money, QUARTERS));
            Console.WriteLine("{0} dimes", ComputeChange(ref money, DIMES));
            Console.WriteLine("{0} nickels", ComputeChange(ref money, NICKELS));
            Console.WriteLine("{0} pennies\n", ComputeChange(ref money, PENNIES));
            Console.ReadLine();
        }

        // The ComputeChange Method
        // Add your method prologue here
        static int ComputeChange(ref int changeValue, int coinValue)
        {
            // you provide the method to compute change here


                int coins = changeValue / coinValue;
                int remainder = changeValue - (coins * coinValue);
                changeValue = remainder;
                return coins;

        }
    }
}
