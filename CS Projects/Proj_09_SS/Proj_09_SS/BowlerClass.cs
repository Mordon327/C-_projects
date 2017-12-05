using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_09_SS
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
