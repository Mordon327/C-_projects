using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console;
// Author: Shane Soderstrom
// Assignment: Lab 16
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004
// Date Written: 3/1/2016
// Description:  This is a program that tells you if you should
// go to work or not.
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.


namespace Lab16_SS
{

            // File Prologue
            // Name: Bob LazyBones
            // CS 1400
            // Project: Work?
            // Date: September 2014
            //


class Program
        {

        static void Main()

        {
            //Constants.
            const int FREEZING = 32;
            int temp;

            // declare some constants for saturday and sunday
            const string SAT = "Saturday";
            const string SUN = "Sunday";

            // declare a variable to hold user's input
            string today;

            // prompt the user to enter a day and get the input
            Console.Write("Please enter a day of the week, e.g. Tuesday: ");
            today = Console.ReadLine();

            //Creat an if statement for when it is and isn't a weekday.
            if (today != SUN && today != SAT)
            {
                //if it is a week day what is the temperature?
                Console.WriteLine("What is the temperature in Fahrenheit?");
                temp = int.Parse(Console.ReadLine());
                //If/else statements for the temperature.
                if (temp > FREEZING)
                {
                    Console.WriteLine("Go to work!");
                }

                else
                {
                    Console.WriteLine("Dress warmly and go to work!");
                }
            }


            

            else
            {
                Console.WriteLine("Ahh... the weekend. No work today!");
            }

            Console.ReadLine();
        
            }//End Main()
        }//End class Program
    }

/*
Questions

At the end of your program write the answers to these two questions. 
Mark your answers as comments so that the compiler will ignore them. 
For both of these questions, suppose that the following declarations have been made:

int num1 = 5;
int num2 = 8;
const int MAX = 10;

(1) Keeping in mind the shortcut rule for evaluating a boolean expression,
what is the value of the following expression? You should assume that x has 
been properly declared, but we do not know the value of x.

((num1 < MAX && num2 < MAX) || x < MAX) true

(2) Now let the value of x be 2. What is the value of this expression?

((num1 < MAX && num2 > MAX) || x < MAX) true

    */