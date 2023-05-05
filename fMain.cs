using QLyQuanAn.DTO;
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
        int loaiTK;
        public fMain()
        {
            InitializeComponent();
            Account acc = Storage.Account.GetAccount();
            loaiTK = acc.LoaiTaiKhoan;

            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            lbName.Text = acc.TenNV;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.contextMenuStrip1.Show(pictureBox1, new Point(e.X, e.Y));
            }
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fDanhMuc f = new fDanhMuc();
            f.Show();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK)
            {
                Storage.Account.DeleteAccount();
                this.Close();
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            f.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doimatkhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau();
            f.Show();
        }
    }
}
