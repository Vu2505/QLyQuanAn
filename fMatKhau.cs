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
    public partial class fMatKhau : Form
    {
        string username = Storage.Account.GetAccount().Username;
        public fMatKhau()
        {
            InitializeComponent();
            txbUsername.Text = username;
        }
        public fMatKhau(string username)
        {
            InitializeComponent();
            txbUsername.Text = username;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

            void UpdateAccountInfo()
            {
                string username = txbUsername.Text;
                string newpass = txbNewPassword.Text;
                if (KiemTra())
                {
                    try
                    {
                        if (AccountDAO.Instance.ResetUpdatePassAccount(username, newpass))
                        {
                            MessageBox.Show("Đổi mật khẩu mới thành công thành công");
                            fLogin f = new fLogin(username);
                            f.ShowDialog();
                        this.Close();
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

                
                if (txbNewPassword.Text == "")
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

        private void btnThoat_Click(object sender, EventArgs e)
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
                txbNewPassword.UseSystemPasswordChar = false;
                txbAgainNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
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
            }
            else
            {
                ptbDeny.Visible = false;
                ptbAccept.Visible = true;
            }
        }
    }
    
}
