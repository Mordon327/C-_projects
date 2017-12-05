using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
// Author: Shane Soderstrom
// Assignment: Project 11
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 4/14/16
// Description: Reads a file and prints the test results.
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_11_SS
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 50;
            string inputString;
            int count = 0;
            Domain dm;
            dm = new Domain();

            // This line of code gets the path to the My Documents Folder
            string environment = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\";

            WriteLine("Enter a file name in My Documents: ");
            string input = Console.ReadLine();

            // concatenate the path to the file name
            string path = environment + input;

            // now we can use the full path to get the document
            StreamReader myFile = new StreamReader(path);



            //WriteLine("read {0}", n);
            inputString = myFile.ReadLine();

            string[] FutalResistance = inputString.Split();

            dm.SetResistor(int.Parse(FutalResistance[0]));
            dm.SetMaxPower(int.Parse(FutalResistance[1]));

            WriteLine($"\nThe resistance is {FutalResistance[0]} and the max power rating is {FutalResistance[1]}.\n");

            WriteLine("Res#\tDissipation\tPassed");

            do
            {
                inputString = myFile.ReadLine(); 

                if (count < MAX && inputString != null)
                {
                    dm.VoltageArray(int.Parse(inputString));

                    WriteLine($"{count + 1}\t{dm.resistorTest(count)}\t\t{dm.GetTest(count)}");

                    count++;

            }

            } while (inputString != null);
           

            ReadLine();



    }
    }
}
