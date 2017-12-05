// CS 1400 example 3
// declarations, assignments, strings and
// using the Console class
// Author: Shane Soderstrom
// Date last modified: January 14, 2016
// --------------------------------------

using System;
using static System.Console;

namespace example03
{
    class Program
    {
        static void Main()
        {
            WriteLine("Hello, my name is Calc.  What is your name?");
            string name = "";
            name = ReadLine();
            WriteLine($"Hello {name}.  I am your personal work assistant.");
            WriteLine("What would you like me to do for you, add, subtract, multiply, or divide?");
            string add = "";
            add = ReadLine();
            if (add == "add") 
            {
                WriteLine("Please enter any two numbers.");

                //readline
                //int.parse();
                int x;
                x = int.Parse(ReadLine());
                int y;
                y = int.Parse(ReadLine());
                int z = x + y;

                int result = x + y;
                WriteLine($"{z} is your answer");
            }
            if (add == "subtract")

            {
                WriteLine("Please enter two single digit numbers.");
                int x;
                x = int.Parse(ReadLine());
                int y;
                y = int.Parse(ReadLine());
                int z = x - y;
                int result = x - y;
                WriteLine($"{z} is your answer");
            }

            if (add == "divide")

            {
                WriteLine("Please enter two single digit numbers.");
                int x;
                x = int.Parse(ReadLine());
                int y;
                y = int.Parse(ReadLine());
                int z = x / y;
                int result = x / y;
                WriteLine($"{z} is your answer");
            }
                if (add == "multiply")
            

            {
                WriteLine("Please enter two single digit numbers.");
                int x;
                x = int.Parse(ReadLine());
                int y;
                y = int.Parse(ReadLine());
                int z = x * y;
                int result = x * y;
                WriteLine($"{z} is your answer");
            }

            //WriteLine("Do you have another math question?");
            //ReadLine();

            //if (ReadLine == yes)
                

            /*


            WriteLine("Hello, my name is Hal.");
            WriteLine("What is your name?");
            String name = "";
            name = ReadLine();
            WriteLine($"Hello {name}, how old are you?");
            int myAge = 0;
            myAge = int.Parse(ReadLine());
            myAge = myAge + 1;
            WriteLine($"How much money do you have {name}");
            double money = 0;
            money = double.Parse(ReadLine());
            WriteLine($"Hello {name}. You are almost {myAge} years old and you have {money}.");
            WriteLine("Press any key to continue.");
            ReadKey(true);

            // identifiers all begin with a letter or undescore
            // they may contain letters, digits, or underscores
            // all names must be declared before they can be used
            // we'll get in the habit of initializing variables early
            int myAge = 0;
            double myHourlyWage = 12.50;

            // objects of the string class hold strings of characters
            string myName = "Roger deBry";
            string courseName = "CS 1400, Fundamentals of Programming";

            // To make something appear on the computer display we use the WriteLine
            // or Write method that belongs to the Console class
            WriteLine("Please enter your age: ");

            // To get something that the user types at the keyboard
            // we use the Readline method that belongs to the Console class
            // Use the Parse method to convert the string data to an integer
            myAge = int.Parse(ReadLine());

            // Let's ouput the values of all of our variables. Notice how we use the
            // placeholder to put the data into the output message.
            WriteLine($"My name is {myName}.");
            WriteLine($"My age is {myAge}.");
            WriteLine($"This course is {courseName}.");
            WriteLine($"Here is my hourly wage {myHourlyWage:C2}.");
            */

            // hold the console window open
            WriteLine("Press any key to continue.");
            ReadKey(true);
        }
    }
}