using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorting_words
{
    public partial class Form1 : Form
    {
        String[] a = new string[100];
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a[n] = textBox1.Text;
            richTextBox1.Text += a[n] + "\n";
            n++;
            textBox1.Text = "";
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(a, 0, n);
            richTextBox1.Text = "";
            for(int i = 0; i <= n; i++)
            {
                richTextBox1.Text += a[i] + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Clear(a, 0, n);
            richTextBox1.Text = " ";
            textBox1.Focus();
        }
    }
}
