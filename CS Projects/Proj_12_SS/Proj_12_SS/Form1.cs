using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Console;
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
    public partial class Form1 : Form
    {
        int count = 0;
        const int MAX = 10;
        Employee[] em = new Employee[MAX];
        int index = 0;


        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;

        }

        /// <summary>
        /// About button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nProject 12");
        }

        /// <summary>
        /// Exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// When the open button is clicked it will open a window in search for a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int count = 0;
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c\\";
            openFileDialog1.Filter = "text files (*.txt)|*txt";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader data = new StreamReader(myStream);
                    string fileLine = (data.ReadLine());

                    while (fileLine != null && count < MAX)
                    {
                        int employeeNumber = int.Parse(fileLine);
                        string name = data.ReadLine();
                        string address = data.ReadLine();
                        string inputString = data.ReadLine();
                        string[] perHour = inputString.Split();
                        double dollars = double.Parse(perHour[0]);
                        int hours = int.Parse(perHour[1]);
                        em[count] = new Employee(employeeNumber, name, address, dollars, hours);
                        count++;
                        fileLine = data.ReadLine();

                    }
                    //display the first set of data in the text boxes.
                    textBox1.Text = em[0].name;
                    textBox2.Text = em[0].address;
                    textBox3.Text = $"{em[0].GetNetPay():C}";
                    button2.Enabled = false;
                    button1.Enabled = true;
                }
            }
        }


        /// <summary>
        /// A button that fetches the next series of data and returns it on click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            if (index >= 0 && index < count)
            {
                index++;
                textBox1.Text = em[index].name;
                textBox2.Text = em[index].address;
                textBox3.Text = $"{em[index].GetNetPay():C}";
                button2.Enabled = true;
            }

            if (index == count - 1)
            {
                    button1.Enabled = false;
            }

        }


        /// <summary>
        /// The previous button that allows you to see the older data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {


            if (index >= 0 && index < count)
            {
                index--;
                textBox1.Text = em[index].name;
                textBox2.Text = em[index].address;
                textBox3.Text = $"{em[index].GetNetPay():C}";
                button1.Enabled = true;
            }

            if (index == 0)
            {
                button2.Enabled = false;
            }




        }
    }
}
