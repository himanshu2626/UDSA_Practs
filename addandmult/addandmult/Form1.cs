using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addandmult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input1 = Convert.ToDouble(textBox1.Text);
                double input2 = Convert.ToDouble(textBox2.Text);

                double result = input1 + input2;

                textBox3.Text = Convert.ToString(result);
            }

            catch(Exception ex)
            {
                MessageBox.Show("Enter valid Number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);

                int result = input1 * input2;

                textBox3.Text = Convert.ToString(result);
            }

            catch(Exception ex)
            {
                MessageBox.Show("Enter valid Number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                textBox1.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter valid Number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to close!");
                this.Close();
            }

            catch(Exception ex)
            {

            }
        }
    }
}
