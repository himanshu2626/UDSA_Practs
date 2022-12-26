using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leapyear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);

            if(year%4 == 0)
            {
                label3.Text = " IT IS A LEAP YEAR!";
            }
            else
            {
                label3.Text = " IT IS NOT A LEAP YEAR";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox1.Focus();
        }
    }
}
