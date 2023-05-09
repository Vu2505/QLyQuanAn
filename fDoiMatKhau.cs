using QLyQuanAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLyQuanAn
{
    public partial class fDoiMatKhau : Form
    {
        string username = Storage.Account.GetAccount().Username;
        public fDoiMatKhau()
        {
            InitializeComponent();
            txbUsername.Text = username;
        }

        void UpdateAccountInfo()
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            string newpass = txbNewPassword.Text;
            if (KiemTra())
            {
                try
                {
                    if (AccountDAO.Instance.UpdatePassAccount(username, password, newpass))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công thành công");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }


        public bool KiemTra()
        {
            
            if (txbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại !!!", "Thông báo");
                txbPassword.Focus();
                return false;
            }
            else if (txbNewPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới !!!", "Thông báo");
                txbNewPassword.Focus();
                return false;
            }
            else if (txbAgainNewPassword.Text == "")
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu !!!", "Thông báo");
                txbAgainNewPassword.Focus();
                return false;
            }
            return true;
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkboxhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxhienthi.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
                txbNewPassword.UseSystemPasswordChar = false;
                txbAgainNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
                txbNewPassword.UseSystemPasswordChar = true;
                txbAgainNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbAgainNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txbNewPassword.Text != txbAgainNewPassword.Text)
            {
                ptbDeny.Visible = true;
                ptbAccept.Visible = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                ptbDeny.Visible = false;
                ptbAccept.Visible = true;
                btnUpdate.Enabled = true;
            }
        }

    }
}
