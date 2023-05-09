using QLyQuanAn.DAO;
using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace QLyQuanAn
{
    public partial class fDanhMuc : Form
    {
        BindingSource foodlist = new BindingSource();
        BindingSource tablelist = new BindingSource();
        BindingSource accountlist = new BindingSource();
        BindingSource categorylist = new BindingSource();
        public fDanhMuc()
        {
            InitializeComponent();
            
            Load();
        }
        void Load()
        {
            dtgvDanhMucFood.DataSource = foodlist;
            dtgvDanhMucBan.DataSource = tablelist;
            dtgvDanhMucAccount.DataSource = accountlist;
            dtgvLoaiMon.DataSource = categorylist;
            LoadListBan();
            //LoadListHoaDon();
            LoadListFood();
            LoadListAccount();
            LoadListCategory();
            LoadCategoryIntoComboBox(cbFoodLoai);
            
        }
        void LoadListFood()
        {
            //string query = "Select * from Mon";
            //foodlist.DataSource = DataProvider.Instance.ExecuteQuery(query);
            foodlist.DataSource = FoodDAO.Instance.GetListFood();
            AddFoodBinding();
        }

        void LoadListBan()
        {
            tablelist.DataSource = TableDAO.Instance.LoadTableList();
            AddTableBinding();
        }

        void LoadListAccount()
        {
            accountlist.DataSource = AccountDAO.Instance.GetListAccount();
            AddAccountBinding();
        }

        void LoadListCategory()
        {
            categorylist.DataSource = CategoryDAO.Instance.GetListCategory1();
            AddCategoryBinding();
        }

        void AddCategoryBinding()
        {
            DeleteCategoryBinding();
            txbIDLoaiMon.DataBindings.Add(new Binding("Text", dtgvLoaiMon.DataSource, "ID"));
            txbNameLoaiMon.DataBindings.Add(new Binding("Text", dtgvLoaiMon.DataSource, "TenLoaiMon", true, DataSourceUpdateMode.Never));
        }

        void DeleteCategoryBinding()
        {
            txbIDLoaiMon.DataBindings.Clear();
            txbNameLoaiMon.DataBindings.Clear();
        }
        void AddAccountBinding()
        {
            DeleteAccountBinding();
            txbIDAccount.DataBindings.Add(new Binding("Text", dtgvDanhMucAccount.DataSource, "IdTK"));
            txbNameAccount.DataBindings.Add(new Binding("Text", dtgvDanhMucAccount.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txbUserName.DataBindings.Add(new Binding("Text", dtgvDanhMucAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txbPassWord.DataBindings.Add(new Binding("Text", dtgvDanhMucAccount.DataSource, "Matkhau", true, DataSourceUpdateMode.Never));
            txbLoaiAccount.DataBindings.Add(new Binding("Text", dtgvDanhMucAccount.DataSource, "LoaiTaiKhoan", true, DataSourceUpdateMode.Never));
            txbTinhTrangAccount.DataBindings.Add(new Binding("Text", dtgvDanhMucAccount.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            txbGhiChuAccount.DataBindings.Add(new Binding("Text", dtgvDanhMucAccount.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
            //LoadListMonAn();
        }
        void DeleteAccountBinding()
        {
            txbIDAccount.DataBindings.Clear();
            txbNameAccount.DataBindings.Clear();
            txbUserName.DataBindings.Clear();
            txbPassWord.DataBindings.Clear();
            txbLoaiAccount.DataBindings.Clear();
            txbTinhTrangAccount.DataBindings.Clear();
            txbGhiChuAccount.DataBindings.Clear();
            //LoadListMonAn();
        }

        private void btnInsertAccount_Click(object sender, EventArgs e)
        {
            DeleteAccountBinding();
            txbNameAccount.Enabled = true;
            txbUserName.Enabled = true;
            txbPassWord.Enabled = true;
            txbLoaiAccount.Enabled = true;
            txbTinhTrangAccount.Enabled = true;
            txbGhiChuAccount.Enabled = true;

            txbIDAccount.Clear();
            txbNameAccount.Clear();
            txbUserName.Clear();
            txbPassWord.Clear();
            txbLoaiAccount.Clear();
            txbTinhTrangAccount.Clear();
            txbGhiChuAccount.Clear();
        }

        List<Account> SearchAccountByName(string name)
        {
            List<Account> listAccount = AccountDAO.Instance.SearchAccountByName(name);
            return listAccount;

        }
        private void txbSearchAccount_TextChanged(object sender, EventArgs e)
        {
            accountlist.DataSource = SearchAccountByName(txbSearchAccount.Text);
        }


        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            txbNameAccount.Enabled = true;
            txbUserName.Enabled = true;
            txbPassWord.Enabled = true;
            txbLoaiAccount.Enabled = true;
            txbTinhTrangAccount.Enabled = true;
            txbGhiChuAccount.Enabled = true;
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string TenNV = txbNameAccount.Text;
            string Username = txbUserName.Text;
            string Matkhau = txbPassWord.Text;
            int LoaiTaiKhoan = Convert.ToInt32(txbLoaiAccount.Text);
            int TinhTrang = Convert.ToInt32(txbTinhTrangAccount.Text);
            string GhiChu = txbGhiChuAccount.Text;

            if (txbIDAccount == null || txbIDAccount.Text == "")
            {
                if (AccountDAO.Instance.InsertAccount(TenNV, Username, Matkhau, LoaiTaiKhoan, TinhTrang, GhiChu))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    LoadListAccount();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm tài khoản");
                }
            }
            else
            {
                int id = Convert.ToInt32(txbIDAccount.Text);
                if (AccountDAO.Instance.UpdateAccount(id, TenNV, Username, Matkhau, LoaiTaiKhoan, TinhTrang, GhiChu))
                {
                    MessageBox.Show("Sửa tài khoản thành công");
                    LoadListAccount();
                }
                else
                {
                    MessageBox.Show("Lỗi khi Sửa tài khoản");
                }
            }

            LoadListAccount();
        }

        private void btnBatAn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDAccount.Text);

            if(txbTinhTrangAccount.Text == "0")
            {
                AccountDAO.Instance.UpdateBatTinhTrangAccount(id);
            }
            else
            {
                AccountDAO.Instance.UpdateTatTinhTrangAccount(id);
            }
            LoadListAccount();
        }

        void AddTableBinding()
        {
            DeleteTableBinding();
            txbTableID.DataBindings.Add(new Binding("Text", dtgvDanhMucBan.DataSource, "ID"));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvDanhMucBan.DataSource, "TenBan", true, DataSourceUpdateMode.Never));
            txbTableTinhTrang.DataBindings.Add(new Binding("Text", dtgvDanhMucBan.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            txbTableGhiChu.DataBindings.Add(new Binding("Text", dtgvDanhMucBan.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
            //LoadListMonAn();
        }

        void DeleteTableBinding()
        {
            txbTableID.DataBindings.Clear();
            txbTableName.DataBindings.Clear();
            txbTableTinhTrang.DataBindings.Clear();
            txbTableGhiChu.DataBindings.Clear();
            //LoadListMonAn();
        }
        void AddFoodBinding()
        {
            DeleteFoodBinding();
              txbFoodID.DataBindings.Add(new Binding("Text",dtgvDanhMucFood.DataSource,"ID"));
              txbFoodName.DataBindings.Add(new Binding("Text", dtgvDanhMucFood.DataSource, "TenMon",true, DataSourceUpdateMode.Never));
              nudFoodGia.DataBindings.Add(new Binding("Text", dtgvDanhMucFood.DataSource, "GiaTien", true, DataSourceUpdateMode.Never));
              txbFoodGhiChu.DataBindings.Add(new Binding("Text", dtgvDanhMucFood.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
        }
        void DeleteFoodBinding()
        {
            txbFoodID.DataBindings.Clear();
            txbFoodName.DataBindings.Clear();
            nudFoodGia.DataBindings.Clear();
            txbFoodGhiChu.DataBindings.Clear();
            //LoadListMonAn();
        }


        void LoadCategoryIntoComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "TenLoaiMon";
        }

        

        //void LoadListHoaDon()
        //{
        //    string query = "Select * from HoaDon";
        //    dtgvDanhMucHoaDon.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;

        }

        List<Category> SearchCategoryByName(string name)
        {
            List<Category> listCategory = CategoryDAO.Instance.SearchCategoryByName(name);
            return listCategory;

        }

        List<Table> SearchTableByName(string name)
        {
            List<Table> listTable = TableDAO.Instance.SearchTableByName(name);
            return listTable;

        }


        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvDanhMucFood.SelectedCells.Count > 0 && dtgvDanhMucFood.SelectedCells[0].OwningRow != null)
                {
                    // Lam viec voi Loai mon 
                    var idStr = dtgvDanhMucFood.SelectedCells[0].OwningRow.Cells["LoaiMon"].Value != null ?
                        dtgvDanhMucFood.SelectedCells[0].OwningRow.Cells["LoaiMon"].Value.ToString() : "-1";
                    int id = int.Parse(idStr);
                    if (id == -1)
                    {
                        txbFoodTinhTrang.Text = "";

                        cbFoodLoai.SelectedIndex = cbFoodLoai.Items.Count - 1;
                        return;
                    }
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cbFoodLoai.SelectedItem = category;

                    int index = 1;
                    int i = 0;
                    foreach (Category item in cbFoodLoai.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbFoodLoai.SelectedIndex = index;

                    // Lam viec voi Tinh trang
                    // voi 1: con; 0: het
                    string tinhTrang = (int)dtgvDanhMucFood.SelectedCells[0].OwningRow.Cells["TinhTrang"].Value == 1 ?
                        "Còn món" : "Hết món";
                    txbFoodTinhTrang.Text = tinhTrang;
                }
            }
            catch(Exception err) { }
        }



        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            foodlist.DataSource = SearchFoodByName(txbSearch.Text);
        }

        private void txbSearchTable_TextChanged(object sender, EventArgs e)
        {
            tablelist.DataSource = SearchTableByName(txbSearchTable.Text);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DeleteFoodBinding();
            txbFoodName.Enabled = true;
            nudFoodGia.Enabled = true;
            txbFoodTinhTrang.Enabled = true;
            cbFoodLoai.Enabled = true;
            txbFoodGhiChu.Enabled = true;
            btnEditFood.Enabled = false;
            txbFoodID.Clear();
            txbFoodName.Clear();
            nudFoodGia.Value = 0;
            txbFoodTinhTrang.Clear();
            txbFoodGhiChu.Clear();

        }

        // them va sua mon an 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            float giatien = (float)nudFoodGia.Value;
            int tinhtrang = int.Parse(txbFoodTinhTrang.Text);
            int loaimon = (cbFoodLoai.SelectedItem as Category).ID;
            string ghichu = txbFoodTinhTrang.Text;
            int id = Convert.ToInt32(txbFoodID.Text);

            if(txbFoodID == null)
            {
                if (FoodDAO.Instance.InsertFood(name, giatien, tinhtrang, loaimon, ghichu))
                {
                    MessageBox.Show("Thêm món thành công");
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm thức ăn");
                }
            }
            else
            { 
                if (FoodDAO.Instance.UpdateFood(id, name, giatien, tinhtrang, loaimon, ghichu))
                {
                    MessageBox.Show("Sửa món thành công");
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Lỗi khi Sửa thức ăn");
                }
            }

            LoadListFood();
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            
            txbFoodName.Enabled = true;
            nudFoodGia.Enabled = true;
            txbFoodTinhTrang.Enabled = true;
            cbFoodLoai.Enabled = true;
            txbFoodGhiChu.Enabled = true;
        }

        private void tbnThemBan_Click(object sender, EventArgs e)
        {
            DeleteTableBinding();
            txbTableName.Enabled = true;
            txbTableTinhTrang.Enabled = true;
            txbTableGhiChu.Enabled = true;
            txbTableID.Clear();
            txbTableName.Clear();
            txbTableTinhTrang.Clear();
            txbTableGhiChu.Clear();
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            txbTableName.Enabled = true;
            txbTableTinhTrang.Enabled = true;
            txbTableGhiChu.Enabled = true;
        }

        //luu them va sua ban
        private void btnSaveTable_Click_1(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            int tinhtrang = int.Parse(txbTableTinhTrang.Text);
            string ghichu = txbTableGhiChu.Text;
            

            if (txbTableID == null || txbTableID.Text == "")
            {
                if (TableDAO.Instance.InsertTable(name, tinhtrang, ghichu))
                {
                    MessageBox.Show("Thêm bàn thành công");
                    LoadListBan();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm bàn");
                }
            }
            else
            {
                int id = Convert.ToInt32(txbTableID.Text);
                if (TableDAO.Instance.UpdateTable(id, name, tinhtrang, ghichu))
                {
                    MessageBox.Show("Sửa bàn thành công");
                    LoadListBan();
                }
                else
                {
                    MessageBox.Show("Lỗi khi Sửa bàn");
                }
            }

            LoadListBan();

        }

        private void btnAnBatFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);

            if (txbFoodTinhTrang.Text == "Hết món")
            {
                FoodDAO.Instance.UpdateBatTinhTrangFood(id);
            }
            else
            {
                FoodDAO.Instance.UpdateTatTinhTrangFood(id);
            }
            LoadListFood();
        }

        private void btnAnBatTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);

            if (txbTableTinhTrang.Text == "0")
            {
                TableDAO.Instance.UpdateBatTinhTrangTable(id);
            }
            else if(txbTableTinhTrang.Text == "2")
            {
                TableDAO.Instance.UpdateTatTinhTrangTable(id);
            }
            else
            {
                MessageBox.Show("Bàn đang có khách không thể bật/ẩn");
            }
            LoadListBan();
        }

        private void btnInsertLoaiMon_Click(object sender, EventArgs e)
        {
            DeleteCategoryBinding();
            txbNameLoaiMon.Enabled = true;
            txbIDLoaiMon.Clear();
            txbNameLoaiMon.Clear();
        }

        private void btnEditLoaiMon_Click(object sender, EventArgs e)
        {
            txbNameLoaiMon.Enabled = true;
        }

        private void btnSaveLoaiMon_Click(object sender, EventArgs e)
        {

            string name =txbNameLoaiMon.Text;

            if (txbIDLoaiMon == null || txbIDLoaiMon.Text == "")
            {
                if (CategoryDAO.Instance.InsertCategoryFood(name))
                {
                    MessageBox.Show("Thêm loại món thành công");
                    LoadListCategory();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm loại món");
                }
            }
            else
            {
                int id = Convert.ToInt32(txbIDLoaiMon.Text);
                if (CategoryDAO.Instance.UpdateCategoryFood(id, name))
                {
                    MessageBox.Show("Sửa loại món thành công");
                    LoadListCategory();
                }
                else
                {
                    MessageBox.Show("Lỗi khi Sửa loại món");
                }
            }

            LoadListCategory();
        }

        private void txbSearchLoaiMon_TextChanged(object sender, EventArgs e)
        {
            categorylist.DataSource = SearchCategoryByName(txbSearchLoaiMon.Text);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
           dtgvDoanhThu.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
            CultureInfo culture = new CultureInfo("vi-VN");
            lbPrice_DT.Text = BillDAO.Instance.GetTotalByDate(checkIn, checkOut).ToString("N0", culture) + " VND"; 
        }
        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpCheckIn.Value, dtpCheckOut.Value);
        }


        void LoadListHistoryBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvDanhMucHoaDon.DataSource = BillDAO.Instance.GetHistoryBillByDate(checkIn, checkOut);
        }

        private void btnThongKeHoaDon_Click(object sender, EventArgs e)
        {
            LoadListHistoryBillByDate(dtpToHistoryBill.Value, dtpFromHistoryBill.Value);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {        
                
            if (txbLoaiAccount.Text == "0")
            {
                int id = Convert.ToInt32(txbIDAccount.Text);
                if (AccountDAO.Instance.UpdateResetPassWordAccount(id))
                {
                    MessageBox.Show("Reset tài khoản thành công");
                    LoadListAccount();
                }
            }
            else if (txbLoaiAccount.Text == "1")
            {
                MessageBox.Show("không thể reset mật khẩu của quản lý");
            }
            LoadListAccount();
        }
    }
}
