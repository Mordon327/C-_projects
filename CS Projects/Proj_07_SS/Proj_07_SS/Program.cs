using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// Author: Shane Soderstrom
// Assignment: project 07
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 3/9/16
// Description: Calculates the reproductive rate of rabbits in pairs,
// Starting with one pair. 

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
namespace Proj_07_SS
{

    class Program
    {
        static void Main(string[] args)
        {
            //declare intigers.
            const int MAX = 500;
            int MONTHS = 0;
            int ADULTS = 1;
            int KIDS = 0;
            int TOTAL = 0;
        
            //Name of the table.
        Console.WriteLine(" Table of rabbit population in pairs.\n");

            Console.WriteLine(" MONTHS\t \tADULTS\t \tKIDS\t \t TOTAL");
            //Method that loops until rabbits exceed number of cages.
            do
            {
                //Increment months, assign variables and output everything.
                MONTHS++;
                TOTAL = ADULTS + KIDS;
                Console.WriteLine($" {MONTHS}\t \t{ADULTS}\t \t{KIDS}\t \t{ADULTS + KIDS}");
                KIDS = ADULTS;
                ADULTS = TOTAL;
            
            } while(TOTAL < MAX);

            //Tell the user when they run out of cages.
            Console.WriteLine($"\n You will run out of cages in {MONTHS}.");

            //Keep the console open for the user to read it.
        Console.ReadKey();

        }
    }
}
