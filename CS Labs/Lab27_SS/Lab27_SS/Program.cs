using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
// Author: Shane Soderstrom
// Assignment: Lab 27
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 4/18/16
// Description: A program that reads in a file and returns the height, width, and depth of a box. 
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.


namespace Lab27_SS
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 10;
            int[] array = new int[MAX];
            string inputString;
            int count = 0;
            Box bx;

            

            // This line of code gets the path to the My Documents Folder
            string environment = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal) + "\\";

            WriteLine("Enter a file name in My Documents:");
            string input = ReadLine();

            // concatenate the path to the file name
            string path = environment + input;



            // now we can use the full path to get the document
            StreamReader myFile = new StreamReader(path);
            
            do
            {
                inputString = myFile.ReadLine();
                

                if (count < MAX && inputString != null)
                {
                    string[] FutalResistance = inputString.Split();

                    int height = int.Parse(FutalResistance[0]);
                    int width = int.Parse(FutalResistance[1]);
                    int depth = int.Parse(FutalResistance[2]);
                    bx = new Box(height, width, depth);
                    WriteLine($"The volume of box {count + 1} is {bx.GetVolume()}");
                    
                    count++;
                }

            } while (inputString != null);
            
            ReadKey(true);
        }
    }
}
