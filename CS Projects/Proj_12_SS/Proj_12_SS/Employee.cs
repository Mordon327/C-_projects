using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: Shane Soderstrom
// Assignment: Project 12
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 4/21/16
// Description: This program calculates an employees pay rate from
// a read in file.
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_12_SS
{
    class Employee
    {
        //constants and arrays declared.
        const int MAX = 10;
        const double INCOMETAX = .2;
        const double STATETAX = .075;
        const int OVERTIME = 41;
        const double HALFTIME = 1.5;
        int count = 0;

        //Getter and setter cheats.
        public int employeeNumber { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double dollars { get; set; }
        public int hours { get; set; }




        /// <summary>
        /// Takes in the information from the read in text and stores it in different arrays.
        /// </summary>
        /// <param name="numberEmployee"></param>
        /// <param name="names"></param>
        /// <param name="addresses"></param>
        /// <param name="dollHours"></param>
        /// <param name="hoursWorked"></param>
        public Employee(int numberEmployee, string names, string addresses, double dollHours, int hoursWorked)
        {
            /*employeeNumber[count] = numberEmployee;
            name[count] = names;
            address[count] = addresses;
            dollars[count] = dollHours;
            hours[count] = hoursWorked;*/
            employeeNumber = numberEmployee;
            name = names;
            address = addresses;
            dollars = dollHours;
            hours = hoursWorked;
            count++;
        }


        /// <summary>
        /// calculates the netpay and returns it.
        /// </summary>
        /// <param name="count"></param>
        /// <returns>netPay</returns>
        public double GetNetPay()
        {
            if (hours < OVERTIME)
            {
                double netPay = 0;




                double income = dollars * hours;
                double incomeTax = income * INCOMETAX;
                double stateTax = income * STATETAX;
                netPay = income - incomeTax - stateTax;
                return netPay;


            }

            else
            {
                double overPayRate = HALFTIME * dollars;
                double overTimeIncome = (hours - OVERTIME) * overPayRate;
                double income = (OVERTIME * dollars) + overTimeIncome;
                double incomeTax = income * INCOMETAX;
                double stateTax = income * STATETAX;
                double netPay = income - incomeTax - stateTax;
                return netPay;
            }
        }
    }
}
