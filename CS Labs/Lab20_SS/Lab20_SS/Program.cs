using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File Prologue
// Name: Shane Soderstrom
// CS 1400 - 004
// Project: Passing Parameters by value and by reference
// Date: 3/22/16
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
namespace Lab20_SS
{
 


class Program
        {
            static void Main()
            {
                // declare some variables to test the program
                int number1 = 10;
                int number2 = 15;

                // call the Swap method and output the result
                Swap(ref number1, ref number2);
                Console.WriteLine("number1 = {0}", number1);
                Console.WriteLine("number2 = {0}", number2);

                Console.ReadLine();
            }

            // The Swap method
            // Purpose: To interchange the value of two variables
            // Parameters: two integers
            // Returns: None
            // Pre-conditions: None
            // Post-conditions: None
            // Side Effect: the values of the 2 integers are swapped

            static void Swap(ref int n1, ref int n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;

            }
        }
    }
    
