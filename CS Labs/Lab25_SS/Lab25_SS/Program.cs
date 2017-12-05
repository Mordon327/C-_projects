using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
// Author: Shane Soderstrom
// Assignment: Lab 25
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 4/12/16
// Description: Uses the File I/O to grab data and return it to the user
// with the average.
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy. 
namespace Lab25_SS
{
    class Program
    {
        static void Main(string[] args)
        {
            const int fifty = 50;
            int[] grades = new int[fifty];
            string inputString;
            int count = 0;
            int numbers = 0;
            double average = 0;

            // This line of code gets the path to the My Documents Folder
            string environment = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal) + "\\";

             WriteLine("Enter a file name in My Documents: ");
            string input = ReadLine();

            //string input = "grades.txt"; // Console.ReadLine();

            // concatenate the path to the file name
            string path = environment + input;
            
            // now we can use the full path to get the document
            StreamReader myFile = new StreamReader(path);

            //int n = int.Parse(myFile.ReadLine());
            //WriteLine("read {0}", n);
            do
            {
                inputString = myFile.ReadLine();
                

                if (count < fifty && inputString != null) 
                {
                    WriteLine($"{inputString}");
                    numbers += int.Parse(inputString);
                    

                    //not quite what I want but close.
                    //grades[numbers] = numbers;
                    count++;
                }
                
            } while (inputString != null);

            average = (double)numbers / count;

            WriteLine($"The average of these numbers is {average}");
            ReadLine();



        }
        }
    }

