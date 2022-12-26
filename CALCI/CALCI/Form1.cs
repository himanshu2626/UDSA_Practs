using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1;
        int num2;
        double result;
        string caltotal;
        string option;

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;
            textBox2.Text = textBox2.Text + btn6.Text;
        }

       

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            textBox2.Text = textBox2.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;
            textBox2.Text = textBox2.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;
            textBox2.Text = textBox2.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;
            textBox2.Text = textBox2.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;
            textBox2.Text = textBox2.Text + btn5.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;
            textBox2.Text = textBox2.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn8.Text;
            textBox2.Text = textBox2.Text + btn8.Text;

        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;
            textBox2.Text = textBox2.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn0.Text;
            textBox2.Text = textBox2.Text + btn0.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            
            option = "+";
           
            num1= Convert.ToInt32(textBox1.Text);
            textBox2.Text = textBox2.Text + "+";
            textBox1.Clear();
        }

        private void bntequals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox1.Text);
            
            if(option.Equals("+")) {
                result = num1 + num2;
                
            }
            if (option.Equals("-"))
            {
                result = num1 - num2;
                
            }
            if(option.Equals("*"))
            {
                result= num1 * num2;
                
            }
            if (option.Equals("/"))
            {
                result = num1 / num2;
                
            }
            if (option.Equals("^"))
            {
                result = Convert.ToInt64(Math.Pow(num1, num2));
                
            }
            textBox2.Text = textBox2.Text + "=";
            textBox1.Text = Convert.ToString(result);
            textBox2.Text = textBox2.Text + result;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "-";

            num1 = Convert.ToInt32(textBox1.Text);
            textBox2.Text = textBox2.Text + "-";
            textBox1.Clear();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            option = "*";

            num1 = Convert.ToInt32(textBox1.Text);
            textBox2.Text = textBox2.Text + "*";
            textBox1.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";

            num1 = Convert.ToInt32(textBox1.Text);
            textBox2.Text = textBox2.Text + "/";
            textBox1.Clear();
        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            option = "^";

            num1 = Convert.ToInt32(textBox1.Text);
            textBox2.Text = textBox2.Text + "^";
            textBox1.Clear();
        }
    }
}
