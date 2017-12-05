using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_01_SS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //This will close the application when the "Exit" button inside of the Exit menu is clicked.
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This displays the said information when the "About" button is clicked.
            MessageBox.Show("Shane Soderstrom\nCS 1400\nProj #1");
        }

        private void Cost_Leave(object sender, EventArgs e)
        {
            //This gives the user the opportunity to input the cost of the meal, AKA original number.
            double num = double.Parse(Cost.Text);

            //Declaring these variables gets rid of magic numbers.
            const double POOR = 1.10;
            const double AVERAGE = 1.15;
            const double EXCELLENT = 1.20;

            //This adds ten percent to the original nmber inputed and out puts the information in the second box.
            double tenNum = num * POOR;
            string outStr1 = $"{tenNum:C}";
            Service1.Text = outStr1;

            //This adds fifteen percent to the original nmber inputed and out puts the information in the third box.
            double fifteenNum = num * AVERAGE;
            string outStr2 = $"{fifteenNum:C}";
            Service2.Text = outStr2;

            //This adds twenty percent to the original nmber inputed and out puts the information in the fourth box.
            double twentyNum = num * EXCELLENT;
            string outStr3 = $"{twentyNum:C}";
            Service3.Text = outStr3;
        }
    }
}
/*You should design your own interface. However, it must provide the functionality described here and it should be easy and intuitive to use.

^ Your interface must include a MenuStrip with an Exit menu item and an About menu item(see lab #4).
^ Your interface must provide a TextBox where the user will enter in the cost of their meal.
^ When the user enters a value and tabs out of this TextBox, your program will calculate three possible tip amounts
(see lab #5):
^ For excellent service calculate a tip that is 20% of the cost of the meal.
^ For average service, calculate a tip that is 15% of the cost of the meal.
^ For poor service, calculate a tip that is 10% of the cost of the meal.
^ Your interface must provide a way to show the tip amounts you calculated.In my example I used TextBoxes.
^ Show all output as dollars and cents correct to 2 decimal places.
^ Your interface should label all of the TextBoxes appropriately.*/