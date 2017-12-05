using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: Shane Soderstrom
// Assignment: Lab 19
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004
// Date Written: 3/10/16
// Description: A console application that asks if it should role 2 dice.
// After receiving a positive answer a random number method will display
// 2 numbers and then it will ask if you want it to do it again. 
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Lab18_SS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNums = new Random();

            //Use writeline to ask if the user wants to roll the dice.
            Console.WriteLine("Would you like to roll the dice ? y / n");

            //Use a readline to get the response.
            string answer = Console.ReadLine();

            //Use the "do while" method to generate a loop.
            while (answer != "n") 
            {

                //If the answer is yes then proceed with the program.
                if (answer == "y")
                {
                    //Use two random dice methods to roll dice.
                    int dieValue = randomNums.Next(1, 7);
                    int dieValue2 = randomNums.Next(1, 7);

                    //If they roll something other than two 1's or 6's use writeline to tell them what they got.
                    Console.WriteLine($"You rolled a {dieValue} and a {dieValue2}.");


                    //If they roll 2 1's use writeline to say snake eyes!
                    if ((dieValue == 1) && (dieValue2 == 1))
                    {
                        Console.WriteLine("You rolled snake eyes!");
                    }

                    //If they roll 2 6's use writeline to say boxcars!
                    if ((dieValue == 6) && (dieValue2 == 6))
                    {
                        Console.WriteLine("You rolled box cars!");
                    }

                }

                //Use writeling to ask them if they want to do it again.
                Console.WriteLine("Would you like to roll the dice again? y/n");

                //Use readline to get a response.

                answer = Console.ReadLine();

                if (answer == "n")
                {
                    break;
                }

                //Use a do method to keep the responses to a yes or no answer.
                //If the answer isn't yes or no use writeline to tell them that the answer isn't valid.
                if ((answer != "y") && (answer != "n"))
                {
                    Console.WriteLine("Invalid input. Try again.");
                }

            } 

            //If the answer is no then use writeline to tell them good bye and close the application.
            Console.WriteLine("Goodbye!");

            //Use readline to keep the program open.
            Console.ReadKey(true);
        }
    }
}
