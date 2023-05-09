
namespace QLyQuanAn
{
    partial class fEditBill
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.nudSoluong = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.dtgvMon = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBillFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.cbLoaiHoaDon = new System.Windows.Forms.ComboBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSearch.Location = new System.Drawing.Point(248, 7);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(265, 38);
            this.txbSearch.TabIndex = 12;
            this.txbSearch.Text = "Tìm kiếm";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // nudSoluong
            // 
            this.nudSoluong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudSoluong.Location = new System.Drawing.Point(519, 7);
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.Size = new System.Drawing.Size(60, 38);
            this.nudSoluong.TabIndex = 11;
            this.nudSoluong.ValueChanged += new System.EventHandler(this.nudSoluong_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(585, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Location = new System.Drawing.Point(4, 7);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(238, 39);
            this.cbLoaiMon.TabIndex = 10;
            this.cbLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbLoaiMon_SelectedIndexChanged);
            // 
            // dtgvMon
            // 
            this.dtgvMon.BackgroundColor = System.Drawing.Color.White;
            this.dtgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMon.Location = new System.Drawing.Point(0, 51);
            this.dtgvMon.Name = "dtgvMon";
            this.dtgvMon.RowHeadersWidth = 51;
            this.dtgvMon.RowTemplate.Height = 29;
            this.dtgvMon.Size = new System.Drawing.Size(705, 529);
            this.dtgvMon.TabIndex = 8;
            this.dtgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMon_CellClick);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(967, 528);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 45);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.Control;
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Location = new System.Drawing.Point(843, 528);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(106, 45);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.panel3.Controls.Add(this.lsvBillFood);
            this.panel3.Controls.Add(this.cbBan);
            this.panel3.Controls.Add(this.cbLoaiHoaDon);
            this.panel3.Controls.Add(this.lbPrice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(711, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 518);
            this.panel3.TabIndex = 13;
            // 
            // lsvBillFood
            // 
            this.lsvBillFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillFood.GridLines = true;
            this.lsvBillFood.HideSelection = false;
            this.lsvBillFood.Location = new System.Drawing.Point(0, 50);
            this.lsvBillFood.Name = "lsvBillFood";
            this.lsvBillFood.Size = new System.Drawing.Size(361, 424);
            this.lsvBillFood.TabIndex = 5;
            this.lsvBillFood.UseCompatibleStateImageBehavior = false;
            this.lsvBillFood.View = System.Windows.Forms.View.Details;
            this.lsvBillFood.SelectedIndexChanged += new System.EventHandler(this.lsvBillFood_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SL";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 100;
            // 
            // cbBan
            // 
            this.cbBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(190, 7);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(171, 39);
            this.cbBan.TabIndex = 4;
            this.cbBan.SelectedIndexChanged += new System.EventHandler(this.cbBan_SelectedIndexChanged);
            // 
            // cbLoaiHoaDon
            // 
            this.cbLoaiHoaDon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLoaiHoaDon.FormattingEnabled = true;
            this.cbLoaiHoaDon.Items.AddRange(new object[] {
            "Ngồi lại",
            "Chuyển bàn"});
            this.cbLoaiHoaDon.Location = new System.Drawing.Point(3, 7);
            this.cbLoaiHoaDon.Name = "cbLoaiHoaDon";
            this.cbLoaiHoaDon.Size = new System.Drawing.Size(181, 39);
            this.cbLoaiHoaDon.TabIndex = 3;
            this.cbLoaiHoaDon.Text = "Ngồi lại";
            this.cbLoaiHoaDon.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHoaDon_SelectedIndexChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(223, 480);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(79, 31);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "0 VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền";
            // 
            // fEditBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(237)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1078, 580);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.nudSoluong);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbLoaiMon);
            this.Controls.Add(this.dtgvMon);
            this.Name = "fEditBill";
            this.Text = "Sửa hóa đơn bàn -1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.NumericUpDown nudSoluong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.Windows.Forms.DataGridView dtgvMon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvBillFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiHoaDon;
    }
}