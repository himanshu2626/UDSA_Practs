using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menudriven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eVENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "SORRY THERE IS NO EVENT AVAILABLE";
        }

        private void eMPTYCARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CART EMPTIED");
        }
    }
}
