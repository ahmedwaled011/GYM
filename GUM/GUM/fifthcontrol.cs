using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUM

{
    public partial class fifthcontrol : UserControl
    {
        public fifthcontrol()
        {
            InitializeComponent();
  
        }
        public static int pro = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Silver)
            {
                pro = pro + 435;
                panel1.BackColor = Color.DarkSeaGreen;
            }
        } 
        private void add435_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkSeaGreen)
            {
                pro = pro + 435;
                panel1.BackColor = Color.Green;
            }
        }
        private void remove435_Click(object sender, EventArgs e)
        {
                if (panel1.BackColor == Color.Green)
                {
                    pro = pro - 435;
                    panel1.BackColor = Color.DarkSeaGreen;
                }
                else if (panel1.BackColor == Color.DarkSeaGreen)
                {
                    pro = pro - 435;
                    panel1.BackColor = Color.Silver;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.BackColor == Color.Silver)
            {
                pro = pro + 590;
                panel2.BackColor = Color.DarkSeaGreen;
            }
        }
        private void add590_Click(object sender, EventArgs e)
        {
            if (panel2.BackColor == Color.DarkSeaGreen)
            {
                pro = pro + 590;
                panel2.BackColor = Color.Green;
            }
        }
        private void remove590_Click(object sender, EventArgs e)
        {
            if (panel2.BackColor == Color.Green)
            {
                pro = pro - 590;
                panel2.BackColor = Color.DarkSeaGreen;
            }
            else if (panel2.BackColor == Color.DarkSeaGreen)
            {
                pro = pro - 590;
                panel2.BackColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel3.BackColor == Color.Silver)
            {
                pro = pro + 530;
                panel3.BackColor = Color.DarkSeaGreen;
            }
        }
        private void add530_Click(object sender, EventArgs e)
        {
            if (panel3.BackColor == Color.DarkSeaGreen)
            {
                pro = pro + 530;
                panel3.BackColor = Color.Green;
            }
        }
        private void remove530_Click(object sender, EventArgs e)
        {
            if (panel3.BackColor == Color.Green)
            {
                pro = pro - 530;
                panel3.BackColor = Color.DarkSeaGreen;
            }
            else if (panel3.BackColor == Color.DarkSeaGreen)
            {
                pro = pro - 530;
                panel3.BackColor = Color.Silver;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel4.BackColor == Color.Silver)
            {
                pro = pro + 995;
                panel4.BackColor = Color.DarkSeaGreen;
            }
        }
        private void add995_Click(object sender, EventArgs e)
        {
            if (panel4.BackColor == Color.DarkSeaGreen)
            {
                pro = pro + 995;
                panel4.BackColor = Color.Green;
            }
        }
        private void remove995_Click(object sender, EventArgs e)
        {
            if (panel4.BackColor == Color.Green)
            {
                pro = pro - 995;
                panel4.BackColor = Color.DarkSeaGreen;
            }
            else if (panel4.BackColor == Color.DarkSeaGreen)
            {
                pro = pro - 995;
                panel4.BackColor = Color.Silver;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox2.Text = pro.ToString();
        }  
        
    }
}
