using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
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
    class Domain
    {
        const int MAX = 50;
        int count = 0;
        double[] array = new double[MAX];
        int resistance;
        int maxPower;

        public void VoltageArray(double value)
        {
            array[count] = value;
            count++;
        }


        public void SetResistor(int res)
        {
            resistance = res; 

        }

        public void SetMaxPower(int power)
        {
            maxPower = power;
        }

        

        public double resistorTest(int arrayIndex)
        {

            double dissipation = array[arrayIndex] * array[arrayIndex] / resistance;
            return dissipation;

        }

        public bool GetTest(int arrayIndex)
        {
            if (resistorTest(arrayIndex) >= maxPower)
            {
                return true;
            }
            else
            {
                return false;
            }

        }






        /*
        static void Swap(ref int a, ref int b)
        {
            WriteLine($"Swapping {a} and {b}");
            int temp = a;
            a = b;
            b = temp;
        }*/



    }
}
