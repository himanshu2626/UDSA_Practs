using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ascending
{
    public partial class Form1 : Form
    {
        int[] a = new int[100];
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a[n] = Convert.ToInt32(textBox1.Text);
                textBox4.Text += a[n] + " ";
                n++;
                textBox1.Text = " ";
                textBox1.Focus();

            }
            catch(Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(a, 0, n);
                for (int i = 0; i < n; i++)
                {
                    textBox2.Text += a[i] + " ";
                }
            }

            catch(Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(a, 0, n);
                Array.Reverse(a, 0, n);
                for (int i = 0; i < n; i++)
                {
                    textBox3.Text += a[i] + " ";
                }
            }

            catch(Exception ex)
            {
              
            }
    }
    }
}
