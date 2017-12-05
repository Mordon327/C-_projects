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
// Assignment: Project 8
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004 
// Date Written: 3/24/16
// Description: This program rolls two dice and displays the numbers along
// the appropriate messages.
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Proj_08_SS
{
    public partial class Form1 : Form
    {
        //Declare constants to refernece when pictures can be seen.
        const int ONE = 1;
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        const int FIVE = 5;
        const int SIX = 6;

        /// <summary>
        /// calls the die class and gives it a name.
        /// </summary>
        private Die die1;

        public Form1()
        {
            InitializeComponent();

            //Creates a new die.
            die1 = new Die();

            //Method that hides labels.
            HideLabels();
        }

        /// <summary>
        /// Close method to close the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Toolstrip method to display a messagebox upon click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nProject 8");
        }

        /// <summary>
        /// On click method to trigger the die roller.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Declare variables for the die roller.
            int numberOne = 1;
            int numberTwo = 2;

            //Create two die rollers.
            die1.DieRollOne(ref numberOne);
            die1.DieRollOne(ref numberTwo);

            //Pictures incognito.
            HidePictures();

            //The eternaly long list of if else statements that flips the image visibility.
            if (numberOne == ONE)
            {
                pictureBox1.Visible = true;
            }

            else if (numberOne == TWO)
            {
                pictureBox2.Visible = true;
            }

            else if (numberOne == THREE)
            {
                pictureBox3.Visible = true;
            }

            else if (numberOne == FOUR)
            {
                pictureBox4.Visible = true;
            }

            else if (numberOne == FIVE)
            {
                pictureBox5.Visible = true;
            }

            else if (numberOne == SIX)
            {
                pictureBox6.Visible = true;
            }

            if (numberTwo == ONE)
            {
                pictureBox7.Visible = true;
            }

            else if (numberTwo == TWO)
            {
                pictureBox8.Visible = true;
            }

            else if (numberTwo == THREE)
            {
                pictureBox9.Visible = true;
            }

            else if (numberTwo == FOUR)
            {
                pictureBox10.Visible = true;
            }

            else if (numberTwo == FIVE)
            {
                pictureBox11.Visible = true;
            }

            else if (numberTwo == SIX)
            {
                pictureBox12.Visible = true;
            }
            
            //If statements to reveal the labels for snake eyes and boxcars.
            if ((numberOne == ONE) && (numberTwo == ONE))
            {
                label1.Visible = true;
            }

            else
            {
                label1.Visible = false;
            }

            if ((numberOne == SIX) && (numberTwo == SIX))
            {
                label2.Visible = true;
            }
            
            else
            {
                label2.Visible = false;
            }
        }
        /// <summary>
        /// This picture method automatically hides all of the pictures.
        /// </summary>
        private void HidePictures()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;

        }

        /// <summary>
        /// Label method that automatically hides the labels.
        /// </summary>
        private void HideLabels()
        {
            label1.Visible = false;
            label2.Visible = false;
        }
            

    }

    
}
