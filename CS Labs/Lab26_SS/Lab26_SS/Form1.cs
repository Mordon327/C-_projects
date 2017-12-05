using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.IO;
// Author: Shane Soderstrom
// Assignment: Lab 26
// Instructor: Timothy Stanley
// Class: CNS 1400 Section: 004
// Date Written: Reads the first line of data from a text file.
// Description: the description of what's in this file 
// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part, 
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

namespace Lab26_SS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Hiding pictures.
            HidePictures();
        }
        
        //Close menu.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //About menu information.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nLab 26");
        }

        /// <summary>
        /// A method that allows you to open a file and read one line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c\\";
            openFileDialog1.Filter = "text files (*.txt)|*txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                    StreamReader data = new StreamReader(myStream);
                    textBox1.Text = data.ReadLine();
                
                }
            if (textBox1.Text != "")
                {
                    pictureBox1.Visible = true;
                }

            }
        }


        /// <summary>
        /// clear button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        /// <summary>
        /// picture method to hide the pictures.
        /// </summary>
        private void HidePictures()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
    }
}
