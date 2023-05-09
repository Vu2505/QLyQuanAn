using QLyQuanAn.DAO;
using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyQuanAn
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if(userName == null || userName == "" 
                || passWord == null || passWord == "")
            {
                MessageBox.Show("Chưa nhập username hay password");
                return;
            }

            Account acc = Login(userName, passWord);
            if (acc != null)
            {
                Storage.Account.SetAccount(acc);

                if(acc.LoaiTaiKhoan ==1)
                {
                    fMain f = new fMain();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    fMainNV f = new fMainNV();
                    this.Hide();
                    f.ShowDialog();
                }
                
                txbPassWord.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

           
        }


        Account Login (String userName, String passWord)
        {
            return AccountDAO.Instance.Login(userName,passWord);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo",MessageBoxButtons.OKCancel) 
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            txbUserName.BackColor = Color.White;
            panelUserName.BackColor = Color.White;
            panelPassword.BackColor = SystemColors.Control;
            txbPassWord.BackColor = SystemColors.Control;
        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {
            txbPassWord.BackColor = Color.White;
            panelPassword.BackColor = Color.White;
            panelUserName.BackColor = SystemColors.Control;
            txbUserName.BackColor = SystemColors.Control;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txbPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
