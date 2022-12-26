using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace displayingpicture
{
    public partial class Form1 : Form
    {
        public static string l1 = "null";
        public static string l2 = "null";
        public static string l3 = "null";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                pictureBox1.Image= new Bitmap(dialog.FileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1= textBox1.Text;
            l2 = textBox2.Text;

            Form2 frm2 = new Form2(pictureBox1.Image);
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
