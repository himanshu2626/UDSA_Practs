using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
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
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);
                int input3 = Convert.ToInt32(textBox3.Text);
                int input4 = Convert.ToInt32(textBox4.Text);

                int total = input1 + input2 + input3 + input4;

                textBox5.Text = total.ToString();
            }

            catch(Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);
                int input3 = Convert.ToInt32(textBox3.Text);
                int input4 = Convert.ToInt32(textBox4.Text);

                double total = input1 + input2 + input3 + input4;

                double avg = total / 4;
                textBox6.Text = avg.ToString();

                String grade;
                if (avg >= 75)
                    grade = "A";
                else if (avg >= 65)
                    grade = "B";
                else if (avg >= 55)
                    grade = "C";
                else if (avg >= 45)
                    grade = "D";
                else
                    grade = "F";

                textBox7.Text = grade;
            }

            catch(Exception ex)
            {

            }

        }
    }
}
