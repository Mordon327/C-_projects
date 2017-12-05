using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: Shane Soderstrom
// Assignment: Project 10
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 4/7/16
// Description: This receives names and scores from people and returns the
// values, names, and who got the high/low scores.

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
namespace Proj_010_SS
{
    class BowlerClass
    {
        //constants.
        const int TOPSCORE = 10000;

        private BowlerClass Bowler;


        /// <summary>
        /// An array that finds the average of the scores.
        /// </summary>
        /// <param name="numbers">score numbers</param>
        /// <param name="count">number of players</param>
        /// <returns>average</returns>
        static double AvgScoreArray(int[] numbers, int count)
        {
            double sum = 0;
            double average = 0;
            foreach (double value in numbers)
            {
                sum += value;
                average = sum / count;
            }
            return average;
        }

        /// <summary>
        /// An array that finds the highest score.
        /// </summary>
        /// <param name="score">Player scores</param>
        /// <param name="count">number of players</param>
        /// <param name="name">Player name</param>
        /// <returns>Player name</returns>
        static string TopDog(ref int[] score, int count, ref string[] name)
        {
            int i = 0;
            int bigBowler = 0;
            string playerName = "";
            for (i = 0; i < count; i++)
            {
                if (bigBowler < score[i])
                {
                    bigBowler = score[i];
                    playerName = name[i];
                }

            }
            return playerName;
        }

        /// <summary>
        /// Finds the lowest score.
        /// </summary>
        /// <param name="score">player scores</param>
        /// <param name="count">Number of players</param>
        /// <param name="name">player names</param>
        /// <param name="TOPSCORE">Highest score possible</param>
        /// <returns>Player name</returns>
        static string LowDog(ref int[] score, int count, ref string[] name, int TOPSCORE)
        {
            int i = 0;
            int lowBowler = TOPSCORE;
            string playerName = "";
            for (i = 0; i < count; i++)
            {

                if (lowBowler >= score[i])
                {
                    lowBowler = score[i];
                    playerName = name[i];
                }


            }
            return playerName;
        }

    }
}
