using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLyQuanAn
{
    public partial class fQLyBan : Form
    {
        public fQLyBan()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAddBill f = new fAddBill();
            f.ShowDialog();
        }
    }
}
