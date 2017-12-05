using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// Author: Shane Soderstrom
// Assignment: Project 09
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 3/31/16
// Description: This receives names and scores from people and returns the
// values, names, and who got the high/low scores.

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_09_SS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Constants and initialize arrays.
            const int ARRAYSIZE = 10;
            string[] name = new string[ARRAYSIZE];
            int[] score = new int[ARRAYSIZE];
            int count = 0;
            string userInput = "";
            const int TOPSCORE = 10000;

            //Make a new array.
            int[] ScoreAverage = new int[ARRAYSIZE];

            //Prompt a response from the user.
            WriteLine("Please enter the bowler's name and score followed by the enter key.  Enter \"\"to end.");


            //While loop to gather names and scores.
            while (count < ARRAYSIZE && userInput != "0")
            {

                userInput = ReadLine();
                if (userInput != "")
                {
                    string[] scoreInformation = userInput.Split();
                    string playerName = scoreInformation[0];
                    int playerScore = int.Parse(scoreInformation[1]);
                    name[count] = playerName;
                    score[count] = playerScore;
                    count++;
                }

                else
                {
                    break;
                }

            }


            WriteLine("Bowlers name: \t Bowlers score:");
            for (int i = 0; i < count; i++)
            {
                WriteLine($"{name[i]}\t\t{score[i]}");
              //  WriteLine($"{BowlingArray(name, i)} && \t{ScoringArray(score, i)}");
            }
            WriteLine($"The top bowler is {TopDog(ref score, count, ref name)}");
            WriteLine($"The low bowler is {LowDog(ref score, count, ref name, TOPSCORE)}");
            WriteLine($"The average score is {AvgScoreArray(score, count)}.");
            WriteLine($"Great job {TopDog(ref score, count, ref name)}!");

            //Keep window open.
                ReadLine();
            
        }//End Main class.





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
                if(bigBowler < score[i])
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
