using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
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
    class Box
    {

        private int height;
        private int width;
        private int depth;

        public Box(int p1, int p2, int p3)
        {
            height = p1;
            width = p2;
            depth = p3;
        }


        public int GetVolume()
        {
            return (height * width * depth);
        }


    }
}
