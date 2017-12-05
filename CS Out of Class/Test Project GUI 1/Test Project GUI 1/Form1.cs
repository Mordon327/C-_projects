using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Project_GUI_1
{
    public partial class Stuff : Form
    {
        public Stuff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtName.Text = "Muffin";
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter) ;
        }
    }
}
