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
    public partial class thirdcontrol : UserControl 
    {
        public thirdcontrol()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 25)
            {
             MessageBox.Show("Don't eat this at all");
            }
            else if (BMI < 18)
            {
             MessageBox.Show("Eat a lot of it, it is healthy for you");
            }
            else
            {
             MessageBox.Show("This is healthy for you in limited quantities");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
            {
             MessageBox.Show("You can eat it in a small amount");
            }
            else if (BMI < 18.5)
            {
             MessageBox.Show("You Must eat it"); 
            }
            else
            {
            MessageBox.Show("This is healthy for you");
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
            {
             MessageBox.Show("Don't eat this at all");
            }
            else if (BMI < 18.5)
            {
             MessageBox.Show("It is not healthy");
            }
            else
            {
             MessageBox.Show("It is not healthy");
            }           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
                {
                    MessageBox.Show("You should drink it to help you");
                }
                else if (BMI < 18.5)
                {
                    MessageBox.Show("It is not preferred for you");
                }
                else
                {
                    MessageBox.Show("It is not preferred for you");
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
                {
                    MessageBox.Show("Don't eat this at all");
                }
                else if (BMI < 18.5)
                {
                    MessageBox.Show("Eat a lot of it, it is healthy for you");
                }
                else
                {
                    MessageBox.Show("This is healthy for you in limited quantities");
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
                {
                    MessageBox.Show("Prefer to you it is healthy");
                }
                else if (BMI < 18.5)
                {
                    MessageBox.Show("Eat a lot of it, it is healthy for you");
                }
                else
                {
                    MessageBox.Show("Eat a lot of it, it is healthy for you");
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
                {
                    MessageBox.Show("Do not eat this");
                }
                else if (BMI < 18.5)
                {
                    MessageBox.Show("You Must eat it");
                }
                else
                {
                    MessageBox.Show("This is healthy for you in limited quantities");
                }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
                {
                    MessageBox.Show("It is possible to drink, but in limited quantities");
                }
                else if (BMI < 18.5)
                {
                    MessageBox.Show("It is useful to you");
                }
                else
                {
                    MessageBox.Show("It is useful to you");
                }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
                {
                    MessageBox.Show("Don't eat this at all");
                }
                else if (BMI < 18.5)
                {
                    MessageBox.Show("It is not healthy");
                }
                else
                {
                    MessageBox.Show("It is not healthy");
                }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double BMI = double.Parse(secoddcontrol.imb.ToString());
            if (BMI > 24.9)
                {
                    MessageBox.Show("Don't eat this at all");
                }
                else if (BMI < 18.5)
                {
                    MessageBox.Show("It is not healthy");
                }
                else
                {
                    MessageBox.Show("It is not healthy");
                }
        }
    }
    
}
