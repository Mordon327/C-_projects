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
    public partial class Form1 : Form
    {
        /// <summary>
        /// Call the shipping class.
        /// </summary>
        private ShippingClass sc;

        public Form1()
        {
            InitializeComponent();
            sc = new ShippingClass();
            sc.Reset();
        }

        
        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Displays information of the project through a message box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nProject 6");
        }


        /// <summary>
        /// When the button is clicked, it uses a series of if statements
        /// to call different methods from the shipping class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                string itemText = comboBox1.Text;
                string itemTextTwo = comboBox2.Text;

                if ((comboBox1.SelectedIndex == 0) &&  (radioButton1.Checked))
                {
                    int items = int.Parse(textBox1.Text);
                    sc.SetItems(items);

                    double itemCost = sc.CalcItemSurStandard();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 0) && (radioButton2.Checked))
                {
                    int items = int.Parse(textBox1.Text);
                    sc.SetItems(items);

                    double itemCost = sc.CalcItemStandard();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 1) && (radioButton1.Checked))
                    {
                    int items = int.Parse(textBox1.Text);
                    sc.SetItems(items);

                    double itemCost = sc.CalcItemSurEXP();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 1) && (radioButton2.Checked))
                {
                    int items = int.Parse(textBox1.Text);
                    sc.SetItems(items);

                    double itemCost = sc.CalcItemExp();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 2) && (radioButton1.Checked))
                {
                    int items = int.Parse(textBox1.Text);
                    sc.SetItems(items);

                    double itemCost = sc.CalcItemSurSameD();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 2) && (radioButton2.Checked))
                {
                    int items = int.Parse(textBox1.Text);
                    sc.SetItems(items);

                    double itemCost = sc.CalcItemSameD();
                    textBox2.Text = $"{itemCost:C}";
                }
            }

            if (comboBox2.SelectedIndex == 1)
            {
                double weight = double.Parse(textBox1.Text);
                sc.SetPounds(weight);

                if ((comboBox1.SelectedIndex == 0) && (radioButton1.Checked))
                {
                    double pounds = double.Parse(textBox1.Text);
                    sc.SetPounds(pounds);

                    double itemCost = sc.CalcLbsSurStandard();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 0) && (radioButton2.Checked))
                {
                    double pounds = double.Parse(textBox1.Text);
                    sc.SetPounds(pounds);

                    double itemCost = sc.CalcLbsStandard();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 1) && (radioButton1.Checked))
                {
                    double pounds = double.Parse(textBox1.Text);
                    sc.SetPounds(pounds);

                    double itemCost = sc.CalcLBSSurEXP();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 1) && (radioButton2.Checked))
                {
                    double pounds = double.Parse(textBox1.Text);
                    sc.SetPounds(pounds);

                    double itemCost = sc.CalcLbsExp();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 2) && (radioButton1.Checked))
                {
                    double pounds = double.Parse(textBox1.Text);
                    sc.SetPounds(pounds);

                    double itemCost = sc.CalcLBSSurSameD();
                    textBox2.Text = $"{itemCost:C}";
                }

                if ((comboBox1.SelectedIndex == 2) && (radioButton2.Checked))
                {
                    double pounds = double.Parse(textBox1.Text);
                    sc.SetPounds(pounds);

                    double itemCost = sc.CalcLbsSameD();
                    textBox2.Text = $"{itemCost:C}";
                }
            }


            //A method that clears the text boxes.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Shipping Method";
            comboBox2.Text = "Shipping Type";
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        /// <summary>
        /// This method changes the text of the label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label();
        }

        /// <summary>
        /// My label method that changes when box 2 changes.
        /// </summary>
        private void label()
        {
            if (comboBox2.SelectedIndex == 1)
            {
                label2.Text = "Number of Pounds";
            }

            else
            {
                label2.Text = "Number of Items";
            }
        }
    }
}
