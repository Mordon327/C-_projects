using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_SS
{
    public partial class CS1400Lab5 : Form
    {
        public CS1400Lab5()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS 1400\nLab #5");
        }

        private void inTXTBox_Leave(object sender, EventArgs e)
        {
            const int DOUBLE = 2;
            int num = int.Parse(inTXTBox.Text);
            int doubledNum = num * DOUBLE;
            string outStr = $"{doubledNum:D}";
            outTXTBox.Text = outStr;
        }
    }
}

//Question #1: Given a variable, cash that contains a currency amount like $4.56, what would the
//statements look like that would properly format and output that variable in a TextBox?
//outTXTBox.Text = $"{cash:C}";
//Question #2: Suppose that you wanted this program to halve the number input by the user.
//Write the line of code that would do that.
//double doubledNum = num / 2;