using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// Author: Shane Soderstrom
// Assignment: Lab 08
// Instructor: Timothey Stanley
// Class: CNS 1400 Section: 004
// Date Written: 2/1/2016 
// Description: This program will calculate the area of unwatered groud based on an inputed
//radius where it is expected that there are four circular watering systems in a square pattern.
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.


namespace Lab08_SS
{
    class Program
    {//Declare Constants such as the number 4.
        const int FOUR = 4;
        static void Main(string[] args)
        {

            //Ask the user for the radius of the watering system.
            Console.WriteLine("Please input the radius of the watering system.");

            //Receive the radius of the watering system through a Parse.
            int radius = int.Parse(ReadLine());

            //Subtract PI from 4. this is because the formula for solving this
            double subtract = FOUR - Math.PI;

            //problem is r^2(4-PI).  We get the 4 from doubling the radius
            //to create the square around the unwatered area for accurate calculations.
            //Multiply raidus * radius * the result from the previus calculation.
            double areaOfCircle = radius * radius * subtract;

            //Read the result back to the user as a double. And varify that it is a square.
            Console.WriteLine($"The area of unwatered property is {areaOfCircle:F}");

            //Have the program hold until the user enters a strike key by using readkey.
            Console.WriteLine("Press any key to continue.");
            ReadKey(true);
        }
    }
}
