using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Shane Soderstrom
// Assignment: Project 5
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 2/25/16
// Description: This class generates a sales receipt.
//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_05_SS
{
    class SalesReceipt
    {
        //Declare variables.
        const int PERCENT = 10000;
        const int STATETAX = 745;
        const int LOCALTAX = 250;
        int numItems;
        double price;

        //Reset method
        /// <summary>
        /// As a default this method turns the numbers to 0.
        /// </summary>
        public void Reset( )
        {
            numItems = 0;
            price = 0;
        }


        //Setter methods
        /// <summary>
        /// Sets the items value.
        /// </summary>
        /// <param name="value">integer</param>
        public void SetItems(int value)
        {
            numItems = value;
        }

        public void SetPrice(double value)
        {
            price = value;
        }

        //Getter methods
        /// <summary>
        /// Figures out the cost of the items before taxes.
        /// </summary>
        /// <returns>double</returns>
        public double PreTaxCost( )
        {
            double itemsCost = numItems * price;
            return itemsCost;
        }


        /// <summary>
        /// Figures out the cost of the tax.
        /// </summary>
        /// <returns>double</returns>
        public double LocalTaxCost( )
        {
            double taxes = numItems * price * LOCALTAX / PERCENT;
            return taxes;
        }


        public double StateTaxCost()
        {
            double taxes = numItems * price * STATETAX / PERCENT;
            return taxes;
        }


        /// <summary>
        /// Adds the cost of the taxes to the cost of the items.
        /// </summary>
        /// <returns>double</returns>
        public double FinalCost( )
        {
            double itemsCost = numItems * price;
            double taxes = itemsCost + StateTaxCost() + LocalTaxCost();
            return taxes;

        }


        //MessageBox method.
        /// <summary>
        /// Displays the answers in a message box.
        /// </summary>
        public void Invoice()
        {
            string Invoice = "Happy Shoppers Receipt...";
            Invoice += "\n'''''''''''''''''''''''''''''''''''''''''''''''";
            Invoice += "\n";
            Invoice += "\n";
            Invoice += "Number of Items:    " + numItems.ToString();
            Invoice += "\nCost of Items:    " + price.ToString("C");
            Invoice += "\n''''''''''''''''''''''''''''''''''''''''";
            Invoice += "\nNet Cost:     " + PreTaxCost().ToString("C");
            Invoice += "\nLocal Tax:   " + LocalTaxCost().ToString("C");
            Invoice += "\nState Tax:   " + StateTaxCost().ToString("C");
            Invoice += "\nFinal Cost:   " + FinalCost().ToString("C");
            Invoice += "\n'''''''''''''''''''''''''''''''''";
            Invoice += "\n";
            Invoice += "\nThank you for shopping!";
            MessageBox.Show(Invoice);
        }
    }
}
