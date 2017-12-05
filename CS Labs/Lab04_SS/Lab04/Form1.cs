using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //The exitToolStripMenItem1 method
        //The purpose: To close the window and end the program
        //The parameters: The object generating the event and the event arguments
        //Returns: None
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //The aboutToolStripMenuItem1 method
        //The Purpose: To bring up information about the assignment
        //The parameters: The object being generated. It generates an information
        //window
        //Returns: None
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shane Soderstrom\nCS1400\nLab #4");
        }
    }
}
// The exitToolStripMenuItem1 method
// Purpose: To close the window and terminate the application
// Parameters: The object generating the event 
// and the event arguments
// Returns: None