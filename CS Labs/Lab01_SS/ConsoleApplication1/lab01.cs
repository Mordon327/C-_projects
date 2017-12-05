// File Prologue
// Name: Shane Soderstrom
// Project: lab01"
// Date:  January 7, 2016


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using static System.Console;

namespace lab_01
{
    static class Program
    {
        static void Main()
        {
            // This program displays my student information
            string name = "Shane Sodersrom";
            string course = "CNS 1400";
            string section = "004";
            string project = "Lab One";

            // This code displays the strings on the console
            WriteLine("Name: {0}", name);
            WriteLine("Course: {0}", course);
            WriteLine("Section: {0}", section);
            WriteLine("Project: {0}", project);

            WriteLine("Press any key to continue");
            ReadKey(true);
        }// End Main
    } // End Class Program
} // End Namespace