using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            attendance1.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            payment1.BringToFront();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            stureg1.BringToFront();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
