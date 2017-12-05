using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: Shane Soderstrom
// Assignment: Project 8
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 3/24/16
// Description: This dice class contains the methods that randomly selects
// a number 1-6. 
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
namespace Proj_08_SS
{
    class Die
    {
        /// <summary>
        /// 
        /// </summary>
        private Random rand;

        //declare constants.
        const int NUM_SIDES = 6;

        /// <summary>
        /// Method to make the die random.
        /// </summary>
        public Die()
        {
            rand = new Random();
        }
        
        /// <summary>
        /// Calls on rand and generates a random number.
        /// </summary>
        /// <param name="outy">integer</param>
        public void DieRollOne(ref int outy)
        {
            outy = rand.Next(1, NUM_SIDES + 1);
        }
    }
}
