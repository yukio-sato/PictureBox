using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void radioButton6_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Icon2;

        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.windows;
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = null;
        }

    }
}
