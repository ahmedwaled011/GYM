using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanl.Height = button1.Height;
            sidepanl.Top = button1.Top;
            firstcontrol1.BringToFront();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sidepanl.Height = button1.Height;
            sidepanl.Top = button1.Top;
            firstcontrol1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanl.Height = button2.Height;
            sidepanl.Top = button2.Top;
            secoddcontrol1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanl.Height = button3.Height;
            sidepanl.Top = button3.Top;
            thirdcontrol1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanl.Height = button4.Height;
            sidepanl.Top = button4.Top;
            fifthcontrol1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanl.Height = button4.Height;
            sidepanl.Top = button5.Top;
            fourthcontrol1.BringToFront();
        }



    }
}
