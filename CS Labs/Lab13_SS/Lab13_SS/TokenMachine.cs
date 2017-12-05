using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: Shane Soderstrom
// Assignment: Lab 13
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/18/2016
// Description: This is a car wash token generator. 
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Lab13_SS
{
    public class TokenMachine
    {
        //Declaring variables.
        int quarters;
        int tokens;
        const int TOKENS = 100;
        const int QUARTERS = 0;


        /// <summary>
        /// Declares the values for the other methods.
        /// </summary>
        public void Reset( )
        {
            //Resets the values in the boxs to their original numbers.
            quarters = QUARTERS;
            tokens = TOKENS;
        }


        /// <summary>
        /// Increases quarters by 1 while decreasing tokens by 1.
        /// </summary>
        public void GetToken( )
        {
            //Subtracts the number of tokens from the machine by one and
            //increases the number of quarters by one.
            quarters++;
            tokens--;
        }

        /// <summary>
        /// Gives the form the number of tokens.
        /// </summary>
        ///<returns>Number of tokens.</returns>
        
        public int CountTokens( )
        {
            //Returns the number of tokens in the machine.
            return tokens;
        }


        /// <summary>
        /// Gives the form the number of tokens.
        /// </summary>
        /// <returns>Number of tokens.</returns>
        public int CountQuarters( )
        {
            //Returns the number of quarters in the machine.
            return quarters;
        }

    }
}
