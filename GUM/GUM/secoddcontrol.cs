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

    public partial class secoddcontrol : UserControl
    {
        public secoddcontrol()
        {
            InitializeComponent();
        }
        public static string imb;

        private void button1_Click(object sender, EventArgs e)           
        {     
            
            double w = double.Parse(textBox1.Text);
            double h = double.Parse(textBox2.Text);
            calc value = new calc(w,h);

            if (textBox1.Text != "" && textBox2.Text != "")
            {
            value.display();  
            imb = value.BMI.ToString();
            textBox4.Text = imb;
            value.condion();
            textBox3.Text = value.text;
            }
            else
            {
                MessageBox.Show("Please Enter you weight ,and you hight");
            }
        }
    }
    public class calc 
    {
        private double weight;
        private double hight;
        public double BMI;
        public string text;
        public calc()
        {
            weight = 0;
            hight = 0;
        }
        public calc(double weight, double hight)
        {
            this.weight = weight;
            this.hight = hight;
        }
        public void display()
        {
            BMI = (weight / (Math.Pow(hight, 2)));
        }
        public void condion()
        {
            if (BMI < 18.5)
            {
                text = "Your weigh less than normal, You need to gain weight";
                MessageBox.Show("Your weigh less than normal, You need to gain weight");
            }
            else if (BMI > 18.5 && BMI < 24.9)
            {
                text = "Your weight is perfect, Maintain your body index";
                MessageBox.Show("Your weight is perfect, Maintain your body index");
            }
            else if (BMI > 24.9 && BMI < 30)
            {
                text = "You are overweight, You must lose some of your weight";
                MessageBox.Show("You are overweight, You must lose some of your weight");
            }
            else if (BMI > 30)
            {
                text = "You are obese, You must work hard to lose your weight";
                MessageBox.Show("You are obese /ln You must work hard to lose your weight");
            }
            else
            {
                MessageBox.Show("This is erro, try again");
            }
        }
    }
}
