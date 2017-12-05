using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Author: Shane Soderstrom
// Assignment: Project 3
// Instructor: Timothey Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/5/2016
// Description: This program reads military time from the user as a start time and an end time.
// This program finds the difference between the times and adds 25% to it and gives it back
// to the user.
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_03_SS
{
    public partial class Project3 : Form
    {
        //Declare constants for math.
        const int HUNDRED = 100;
        const int PERCENT = 25;
        const int HOUR = 24;
        const int MINUTE = 60;

        public Project3()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nProj 03");
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            //Receive start time from user in military format hhmm.
            int firstTime = int.Parse(StartTime.Text);

            //Receibe end time from user in military format hhmm.
            int secondtime = int.Parse(EndTime.Text);

            //Divide the hours from the two times.
            double hourOne = firstTime / HUNDRED;
            double hourTwo = secondtime / HUNDRED;

            //Moduluse the minutes from the two times.
            double minuteOne = firstTime % HUNDRED;
            double minuteTwo = secondtime % HUNDRED;


            //New Code:
            //Minute Math:
            //divide minutes by 60.
            //double decimalMinOne = minuteOne / MINUTE;
            //double decimalMinTwo = minuteTwo / MINUTE;

            //subtract decimals and keep as absolute value.
            double minDifference = Math.Abs(minuteTwo - minuteOne);
            double minSum = minDifference + minuteTwo;
            double adjMin = minSum * PERCENT / HUNDRED;
            double increaseMin = adjMin + minSum;
            //add the difference of the minutes to the second time.
            //double totalMin = minDifference + minuteTwo;

            //multiply by 60
            double finalMin = increaseMin / MINUTE;
            double totalMin = finalMin * HUNDRED;



            //Hour Math:
            //Divide hours by 24.
            double decimalHrOne = hourOne * MINUTE;
            double decimalHrTwo = hourTwo * MINUTE;

            //Subtract decimals and keep as absolute value.
            double hourDifference = Math.Abs(decimalHrTwo - decimalHrOne);
            double hourSum = hourDifference + decimalHrTwo;
            double adjHour = hourSum * PERCENT / HUNDRED;
            double increaseHour = adjHour + hourSum;

            //Multiply hours by 24 and 100.
            double totalHour = increaseHour / 60 * HUNDRED;

            //Add the difference of the minutes to the second time.
            //double finalHour = totalHour + (hourTwo * HUNDRED);

            //Total Math + Readout.
            //Add hours and minutes.
            int finalTime = (int)totalMin + (int)totalHour;
            NewTime.Text = $"{finalTime:D4}";



            /*
            //Minute Math:
            //divide minutes by 60.
            double decimalMinOne = minuteOne / MINUTE;
            double decimalMinTwo = minuteTwo / MINUTE;

            //subtract decimals and keep as absolute value.
            double minDifference = Math.Abs(decimalMinTwo - decimalMinOne);
            double minSum = minDifference + decimalMinTwo;
            //add the difference of the minutes to the second time.
            //double totalMin = minDifference + minuteTwo;

            //multiply by 60
            double finalMin = minSum * MINUTE;



            //Hour Math:
            //Divide hours by 24.
            double decimalHrOne = hourOne / HOUR;
            double decimalHrTwo = hourTwo / HOUR;

            //Subtract decimals and keep as absolute value.
            double hourDifference = Math.Abs(decimalHrTwo - decimalHrOne);
            double hourSum = hourDifference + decimalHrTwo;

            //Multiply hours by 24 and 100.
            double totalHour = hourSum * HOUR * HUNDRED;

            //Add the difference of the minutes to the second time.
            //double finalHour = totalHour + (hourTwo * HUNDRED);

            //Total Math + Readout.
            //Add hours and minutes.
            int finalTime = (int)finalMin + (int)totalHour;
            NewTime.Text = $"{finalTime:D4}";
            */

            /*
            double minDifference = (hourTwo * MINUTE) + minuteTwo - (hourOne * MINUTE) - minuteOne;
            double adjMin = minDifference * PERCENT / HUNDRED;
            double calcMin = (hourTwo * MINUTE) + minuteTwo + adjMin;
            double calcHour = calcMin / MINUTE;
            double Min = calcMin - calcHour * MINUTE;
            
            double moreMinutes = calcHour % HUNDRED;
            double rightMin = moreMinutes / MINUTE;
            double newTime = (int)calcHour * HUNDRED + rightMin * HUNDRED;
            NewTime.Text = $"{(int)newTime:D4}";
            */







            /*
            //Subtract hour one from two then divide the total by 24.
            double newHour = Math.Abs((hourTwo - hourOne));

            //Subtract minute one from two then divide the total by 60.
            double newMinute = Math.Abs((minuteTwo - minuteOne));

            //Multiply the new times by 25% and divide by 100.
            double hour = newHour * PERCENT / HUNDRED;
            double minute = newMinute * PERCENT / HUNDRED;

            //Add this new time to the original hour.
            double arriveHour = hour + hourOne;
            double arriveMinute = minute + minuteOne;
            int arriveTime = ((int)arriveHour * HUNDRED) + (int)arriveMinute;

            //Display the new times.
            NewTime.Text = $"{arriveTime:D2}";
            */
        }

    }
}
