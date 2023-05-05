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
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();

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
    }
}
