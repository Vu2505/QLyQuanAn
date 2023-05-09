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
    public partial class fMainNV : Form
    {
        int loaiTK;
        public fMainNV()
        {
            InitializeComponent();
            Account acc = Storage.Account.GetAccount();
            loaiTK = acc.LoaiTaiKhoan;

            ptbAvatar.ContextMenuStrip = contextMenuStrip1;
            lbNAmeNV.Text = acc.TenNV;
        }

        private void ptbAvatar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.contextMenuStrip1.Show(ptbAvatar, new Point(e.X, e.Y));
            }
        }

        private void ptbAddBill_Click(object sender, EventArgs e)
        {
            fAddBill f = new fAddBill();
            f.Show();
        }

        private void ptbTable_Click(object sender, EventArgs e)
        {
            fQLyBan f = new fQLyBan();
            f.Show();
        }

        private void ChangePassWord_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau();
            f.Show();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK)
            {
                Storage.Account.DeleteAccount();
                this.Close();
            }
        }
    }
}
