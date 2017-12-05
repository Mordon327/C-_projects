// CS 1400
// Author: Shane Soderstrom
// Date created January 13, 2016
// --------------------------------------

using System;
using static System.Console;

namespace example03
{
    class Program
    {
        static void Main()
        {

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
        }
    }
}