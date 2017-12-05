using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: Shane Soderstrom
// Assignment: Project 6
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 3/3/16
// Description: This program calculates the cost of three different
//shipping costs. 

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_6_SS
{


    class ShippingClass
    {
        //Declare constants and variables.
        const double STDSURCHARGE = 2.50;
        const double EXPSURCHARGE = 5.00;
        const double SAMEDSURCHARGE = 8.00;

        const double ITEMSTD = 3.00;
        const double ITEMEXP = 4.00;
        const double ITEMSAMED = 5.50;

        const double LBSSTD = 1.45;
        const double LBSEXP = 2.50;
        const double LBSSAMED = 3.00;

        int items;
        double pounds;

        /// <summary>
        /// Hold a value for items and pounds.
        /// </summary>
        public void Reset()
        {
            items = 0;
            pounds = 0;
        }

        /// <summary>
        /// Sets the value of items and pounds.
        /// </summary>
        /// <param name="NumberItems"></param>
        public void SetItems(int NumberItems)
        {
            items = NumberItems;
        }
            
        public void SetPounds(double NumberPounds)
        {
            pounds = NumberPounds;
        }



        /// <summary>
        /// The four methods for the standard services.
        /// </summary>
        /// <returns>cost</returns>
        public double CalcItemStandard()
        {
            
            double cost = ITEMSTD * items;
            return cost;            
        }

        public double CalcItemSurStandard()
        {

            double cost = (ITEMSTD * items) + STDSURCHARGE;
            return cost;
        }

        public double CalcLbsStandard()
        {
            double cost = LBSSTD * pounds;
            return cost;
        }

        public double CalcLbsSurStandard()
        {

            double cost = (LBSSTD * pounds) + STDSURCHARGE;
            return cost;
        }




        /// <summary>
        /// The four methods for the express shipping services.
        /// </summary>
        /// <returns>cost</returns>
        public double CalcItemExp()
        {
            double cost = ITEMEXP * items;
            return cost;
        }

        public double CalcItemSurEXP()
        {

            double cost = (ITEMEXP * items) + EXPSURCHARGE;
            return cost;
        }

        public double CalcLbsExp()
        {
            double cost = LBSEXP * pounds;
            return cost;
        }

        public double CalcLBSSurEXP()
        {

            double cost = (LBSEXP * pounds) + EXPSURCHARGE;
            return cost;
        }




        /// <summary>
        /// The four methods for the same day services.
        /// </summary>
        /// <returns>cost</returns>
        public double CalcItemSameD()
        {
            double cost = ITEMSAMED * items;
            return cost;
        }

        public double CalcItemSurSameD()
        {

            double cost = (ITEMEXP * items) + SAMEDSURCHARGE;
            return cost;
        }


        public double CalcLbsSameD()
        {
            double cost = LBSSAMED * items;
            return cost;
        }

        public double CalcLBSSurSameD()
        {

            double cost = (LBSSAMED * pounds) + SAMEDSURCHARGE;
            return cost;
        }

    }
}
