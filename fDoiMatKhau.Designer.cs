
namespace QLyQuanAn
{
    partial class fDoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbAccept = new System.Windows.Forms.PictureBox();
            this.ptbDeny = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.checkboxhienthi = new System.Windows.Forms.CheckBox();
            this.txbAgainNewPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeny)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbAccept);
            this.panel1.Controls.Add(this.ptbDeny);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.checkboxhienthi);
            this.panel1.Controls.Add(this.txbAgainNewPassword);
            this.panel1.Controls.Add(this.txbNewPassword);
            this.panel1.Controls.Add(this.txbPassword);
            this.panel1.Controls.Add(this.txbUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 440);
            this.panel1.TabIndex = 0;
            // 
            // ptbAccept
            // 
            this.ptbAccept.BackColor = System.Drawing.SystemColors.Control;
            this.ptbAccept.BackgroundImage = global::QLyQuanAn.Properties.Resources.yes;
            this.ptbAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbAccept.Location = new System.Drawing.Point(432, 266);
            this.ptbAccept.Name = "ptbAccept";
            this.ptbAccept.Size = new System.Drawing.Size(29, 29);
            this.ptbAccept.TabIndex = 13;
            this.ptbAccept.TabStop = false;
            this.ptbAccept.Visible = false;
            // 
            // ptbDeny
            // 
            this.ptbDeny.BackColor = System.Drawing.SystemColors.Control;
            this.ptbDeny.BackgroundImage = global::QLyQuanAn.Properties.Resources.remove;
            this.ptbDeny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbDeny.Location = new System.Drawing.Point(432, 266);
            this.ptbDeny.Name = "ptbDeny";
            this.ptbDeny.Size = new System.Drawing.Size(29, 29);
            this.ptbDeny.TabIndex = 12;
            this.ptbDeny.TabStop = false;
            this.ptbDeny.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 34);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(89, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông tin thay đổi mật khẩu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 38);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Đổi mật khẩu";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // checkboxhienthi
            // 
            this.checkboxhienthi.AutoSize = true;
            this.checkboxhienthi.Location = new System.Drawing.Point(165, 321);
            this.checkboxhienthi.Name = "checkboxhienthi";
            this.checkboxhienthi.Size = new System.Drawing.Size(148, 24);
            this.checkboxhienthi.TabIndex = 8;
            this.checkboxhienthi.Text = "Hiển thị mật khẩu";
            this.checkboxhienthi.UseVisualStyleBackColor = true;
            this.checkboxhienthi.CheckedChanged += new System.EventHandler(this.checkboxhienthi_CheckedChanged);
            // 
            // txbAgainNewPassword
            // 
            this.txbAgainNewPassword.Location = new System.Drawing.Point(165, 266);
            this.txbAgainNewPassword.Name = "txbAgainNewPassword";
            this.txbAgainNewPassword.Size = new System.Drawing.Size(261, 27);
            this.txbAgainNewPassword.TabIndex = 7;
            this.txbAgainNewPassword.UseSystemPasswordChar = true;
            this.txbAgainNewPassword.TextChanged += new System.EventHandler(this.txbAgainNewPassword_TextChanged);
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Location = new System.Drawing.Point(165, 209);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(261, 27);
            this.txbNewPassword.TabIndex = 6;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(165, 149);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(261, 27);
            this.txbPassword.TabIndex = 5;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUsername
            // 
            this.txbUsername.Enabled = false;
            this.txbUsername.Location = new System.Drawing.Point(165, 89);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(261, 27);
            this.txbUsername.TabIndex = 4;
            this.txbUsername.Text = "cvzvz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 442);
            this.Controls.Add(this.panel1);
            this.Name = "fDoiMatKhau";
            this.Text = "fDoiMatKhau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeny)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkboxhienthi;
        private System.Windows.Forms.TextBox txbAgainNewPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox ptbDeny;
        private System.Windows.Forms.PictureBox ptbAccept;
    }
}