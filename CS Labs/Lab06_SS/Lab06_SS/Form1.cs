using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_SS
{
    //This program converts inputed inches(the circumfrance of
    //a wagon wheel) and tells you the number of rotations their
    //are in a mile.
    
    


    public partial class Form1 : Form
    {
        //Declaire constants.
        const int MILE = 63360;
        const int TWO = 2;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Make the exit button close the application.
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the lab information in a message box.
            MessageBox.Show("Shane Soderstrom\nCS 1400\nLab 07");
        }

        private void Input_Leave(object sender, EventArgs e)
        {
            //Receives diameter from user throu Input textbox and stores as a double.
            double diameter = double.Parse(Input.Text);
            //Circumference=3.14*diameter.
            double circumference = Math.PI * diameter;
            //Divide the number of inches in a mile by the circumference in inches.
            double rotation = MILE / circumference;
            //State the result as a string through the out text box.
            Output.Text = $"{rotation:F}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button sets what is in the textboxs to nothing.
            Input.Text = "";
            Output.Text = "";
        }



        /*Personal notes for future reference:
          private void inTXTBox_Leave(object sender, EventArgs e)

            const int DOUBLE = 2;
            int num = int.Parse(inTXTBox.Text);
            int doubledNum = num * DOUBLE;
            string outStr = $"{doubledNum:D}";
            outTXTBox.Text = outStr;
            $ tells the program to do stuff
            "" says that what is inside is a string
            {} what is inside is displayed
            :F displays an integer, :C displays the integer in currency format, :D displays integer with 2 decimal places.

          */
    }
}
