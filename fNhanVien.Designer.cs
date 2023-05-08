
namespace QLyQuanAn
{
    partial class fNhanVien
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvListNhanVien = new System.Windows.Forms.DataGridView();
            this.txbSearchNhanVien = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAnBatNhanVien = new System.Windows.Forms.Button();
            this.cbxTrangThaiNV = new System.Windows.Forms.ComboBox();
            this.cbxGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.txbDiaChiNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveNV = new System.Windows.Forms.Button();
            this.txbSDTNV = new System.Windows.Forms.TextBox();
            this.txbCCCDNV = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnInsertNV = new System.Windows.Forms.Button();
            this.txbNameNV = new System.Windows.Forms.TextBox();
            this.txbIDNV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNhanVien)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 582);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.dtgvListNhanVien);
            this.groupBox5.Controls.Add(this.txbSearchNhanVien);
            this.groupBox5.Location = new System.Drawing.Point(14, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1054, 354);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin nhân viên";
            // 
            // dtgvListNhanVien
            // 
            this.dtgvListNhanVien.AllowUserToOrderColumns = true;
            this.dtgvListNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNhanVien,
            this.GioiTinh,
            this.CCCD,
            this.SDT,
            this.DiaChi,
            this.TrangThai});
            this.dtgvListNhanVien.Location = new System.Drawing.Point(0, 67);
            this.dtgvListNhanVien.Name = "dtgvListNhanVien";
            this.dtgvListNhanVien.RowHeadersWidth = 51;
            this.dtgvListNhanVien.RowTemplate.Height = 29;
            this.dtgvListNhanVien.Size = new System.Drawing.Size(1054, 287);
            this.dtgvListNhanVien.TabIndex = 18;
            // 
            // txbSearchNhanVien
            // 
            this.txbSearchNhanVien.Location = new System.Drawing.Point(416, 26);
            this.txbSearchNhanVien.Name = "txbSearchNhanVien";
            this.txbSearchNhanVien.Size = new System.Drawing.Size(213, 27);
            this.txbSearchNhanVien.TabIndex = 19;
            this.txbSearchNhanVien.TextChanged += new System.EventHandler(this.btnSearchNhanVien_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.btnAnBatNhanVien);
            this.groupBox6.Controls.Add(this.cbxTrangThaiNV);
            this.groupBox6.Controls.Add(this.cbxGioiTinhNV);
            this.groupBox6.Controls.Add(this.txbDiaChiNV);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.btnSaveNV);
            this.groupBox6.Controls.Add(this.txbSDTNV);
            this.groupBox6.Controls.Add(this.txbCCCDNV);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.btnEditNV);
            this.groupBox6.Controls.Add(this.btnInsertNV);
            this.groupBox6.Controls.Add(this.txbNameNV);
            this.groupBox6.Controls.Add(this.txbIDNV);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(14, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1054, 196);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin chi tiết nhân viên";
            // 
            // btnAnBatNhanVien
            // 
            this.btnAnBatNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnAnBatNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnBatNhanVien.Location = new System.Drawing.Point(710, 144);
            this.btnAnBatNhanVien.Name = "btnAnBatNhanVien";
            this.btnAnBatNhanVien.Size = new System.Drawing.Size(94, 29);
            this.btnAnBatNhanVien.TabIndex = 33;
            this.btnAnBatNhanVien.Text = "Ẩn/Bật";
            this.btnAnBatNhanVien.UseVisualStyleBackColor = false;
            this.btnAnBatNhanVien.Click += new System.EventHandler(this.btnAnBatNhanVien_Click);
            // 
            // cbxTrangThaiNV
            // 
            this.cbxTrangThaiNV.FormattingEnabled = true;
            this.cbxTrangThaiNV.Items.AddRange(new object[] {
            "Đang làm",
            "Thôi Việc"});
            this.cbxTrangThaiNV.Location = new System.Drawing.Point(826, 89);
            this.cbxTrangThaiNV.Name = "cbxTrangThaiNV";
            this.cbxTrangThaiNV.Size = new System.Drawing.Size(208, 28);
            this.cbxTrangThaiNV.TabIndex = 32;
            // 
            // cbxGioiTinhNV
            // 
            this.cbxGioiTinhNV.FormattingEnabled = true;
            this.cbxGioiTinhNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinhNV.Location = new System.Drawing.Point(112, 143);
            this.cbxGioiTinhNV.Name = "cbxGioiTinhNV";
            this.cbxGioiTinhNV.Size = new System.Drawing.Size(208, 28);
            this.cbxGioiTinhNV.TabIndex = 31;
            // 
            // txbDiaChiNV
            // 
            this.txbDiaChiNV.Enabled = false;
            this.txbDiaChiNV.Location = new System.Drawing.Point(826, 37);
            this.txbDiaChiNV.Name = "txbDiaChiNV";
            this.txbDiaChiNV.Size = new System.Drawing.Size(208, 27);
            this.txbDiaChiNV.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Địa Chỉ";
            // 
            // btnSaveNV
            // 
            this.btnSaveNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnSaveNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNV.Location = new System.Drawing.Point(596, 144);
            this.btnSaveNV.Name = "btnSaveNV";
            this.btnSaveNV.Size = new System.Drawing.Size(94, 29);
            this.btnSaveNV.TabIndex = 25;
            this.btnSaveNV.Text = "Lưu";
            this.btnSaveNV.UseVisualStyleBackColor = false;
            this.btnSaveNV.Click += new System.EventHandler(this.btnSaveNV_Click);
            // 
            // txbSDTNV
            // 
            this.txbSDTNV.Enabled = false;
            this.txbSDTNV.Location = new System.Drawing.Point(472, 89);
            this.txbSDTNV.Name = "txbSDTNV";
            this.txbSDTNV.Size = new System.Drawing.Size(208, 27);
            this.txbSDTNV.TabIndex = 24;
            // 
            // txbCCCDNV
            // 
            this.txbCCCDNV.Enabled = false;
            this.txbCCCDNV.Location = new System.Drawing.Point(472, 37);
            this.txbCCCDNV.Name = "txbCCCDNV";
            this.txbCCCDNV.Size = new System.Drawing.Size(208, 27);
            this.txbCCCDNV.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Giới Tính";
            // 
            // btnEditNV
            // 
            this.btnEditNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnEditNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNV.Location = new System.Drawing.Point(482, 144);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(94, 29);
            this.btnEditNV.TabIndex = 18;
            this.btnEditNV.Text = "Sửa";
            this.btnEditNV.UseVisualStyleBackColor = false;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnInsertNV
            // 
            this.btnInsertNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.btnInsertNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertNV.Location = new System.Drawing.Point(375, 144);
            this.btnInsertNV.Name = "btnInsertNV";
            this.btnInsertNV.Size = new System.Drawing.Size(94, 29);
            this.btnInsertNV.TabIndex = 13;
            this.btnInsertNV.Text = "Thêm";
            this.btnInsertNV.UseVisualStyleBackColor = false;
            this.btnInsertNV.Click += new System.EventHandler(this.btnInsertNV_Click);
            // 
            // txbNameNV
            // 
            this.txbNameNV.Enabled = false;
            this.txbNameNV.Location = new System.Drawing.Point(112, 91);
            this.txbNameNV.Name = "txbNameNV";
            this.txbNameNV.Size = new System.Drawing.Size(208, 27);
            this.txbNameNV.TabIndex = 7;
            // 
            // txbIDNV
            // 
            this.txbIDNV.Enabled = false;
            this.txbIDNV.Location = new System.Drawing.Point(112, 38);
            this.txbIDNV.Name = "txbIDNV";
            this.txbIDNV.Size = new System.Drawing.Size(208, 27);
            this.txbIDNV.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(367, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Số Điện Thoại";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(367, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "CCCD";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Tên nhân viên";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã NV";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 580);
            this.Controls.Add(this.panel1);
            this.Name = "fNhanVien";
            this.Text = "fNhanVien";
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNhanVien)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSaveNV;
        private System.Windows.Forms.TextBox txbSDTNV;
        private System.Windows.Forms.TextBox txbCCCDNV;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnInsertNV;
        private System.Windows.Forms.TextBox txbNameNV;
        private System.Windows.Forms.TextBox txbIDNV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvListNhanVien;
        private System.Windows.Forms.TextBox txbSearchNhanVien;
        private System.Windows.Forms.TextBox txbDiaChiNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxGioiTinhNV;
        private System.Windows.Forms.ComboBox cbxTrangThaiNV;
        private System.Windows.Forms.Button btnAnBatNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}