using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLyQuanAn
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            fAddBill f = new fAddBill();
            f.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            fQLyBan f = new fQLyBan();
            f.Show();
        }
    }
}
