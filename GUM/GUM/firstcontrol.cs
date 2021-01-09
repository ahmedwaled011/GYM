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
    public partial class firstcontrol : UserControl
    {
        public firstcontrol()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Male" && textBox2.Text != "")
            {
                MessageBox.Show("          Wellcom Mr. " + textBox2.Text);
                textBox3.Text = "                Wellcom Mr. " + textBox2.Text;
            }
            else if (comboBox1.Text == "Female" && textBox2.Text != "")
            {
                MessageBox.Show("          Wellcom Miss. " + textBox2.Text);
                textBox3.Text = "                Wellcom Miss. " + textBox2.Text;
            }
            else
            {
                MessageBox.Show("          There are erro in your name or your gender");
            }
        }
    }
}
