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
    public partial class fEditBill : Form
    {

        int IdMon;
        Table table;
        int chuyenBan;
        int idHD;
        float tongtien = 0;
        int idTk = Storage.Account.GetAccount().IdTK;
        public fEditBill()
        {
            InitializeComponent();
            LoadMonAnList();
            LoadCategory();
            ShowBill(table.ID);
            GetBillId(table.ID);
        }

        public fEditBill(Table table)
        {
            InitializeComponent();
            LoadMonAnList();
            LoadCategory();
            this.table = table;
            ShowBill(table.ID);
            GetBillId(table.ID);
        }

        void LoadMonAnList()
        {
            string query = "Select * from Mon";
            dtgvMon.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbLoaiMon.DataSource = listCategory;
            cbLoaiMon.DisplayMember = "TenLoaiMon";
        }

        void LoadAddTable()
        {
            List<Table> listTable = TableDAO.Instance.LoadAddTableList();
            cbBan.DataSource = listTable;
            cbBan.DisplayMember = "Tenban";
            cbBan.ValueMember = "ID";
        }

        void ShowBill(int id)
        {
            lsvBillFood.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float tongTien = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenMon.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.Soluong.ToString());
                lsvItem.SubItems.Add(item.Thanhtien.ToString());
                lsvBillFood.Items.Add(lsvItem);
                tongTien += item.Thanhtien;
            }            

            CultureInfo culture = new CultureInfo("vi-VN");
            lbPrice.Text = tongTien.ToString("N0", culture) + " VND";

            //LoadTable();
        }

        void GetBillId(int id)
        {
            idHD = MenuDAO.Instance.GetIdBill(id);            
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            if (cbLoaiMon.Text == "ALL" || id ==1)
            {
                string query = "Select * from Mon";
                dtgvMon.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                string query = "Select * from Mon where LoaiMon = " + id;
                dtgvMon.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }

        }

        private void Enable_btnXacNhan()
        {
            if (lsvBillFood.Items.Count == 0 || cbLoaiHoaDon.Text == "")
            {
                btnXacNhan.Enabled = false;
            }
            else
            {
                btnXacNhan.Enabled = true;
            }
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;

        }


        #region event
        private void button3_Click(object sender, EventArgs e)
        {
            lsvBillFood.Items.Clear();
            lbPrice.Text = "0";
            nudSoluong.Value = 0;
            lbPrice.Text = "0 VNĐ";

            ShowBill(table.ID);
        }      


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xác nhận hóa đơn hay không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                // danh sách món cũ (xoá hết)
                // Example : 2, 4, 7
                var listMonCu = BIllInfoDAO.Instance.GetInfoBill(idHD);                
                // Khi xét hết listMonMoi mà còn id trong listMonCu --> cần delete
                foreach (int idMonCu in listMonCu)
                {
                    BIllInfoDAO.Instance.DeleteInfoBill(idHD, idMonCu);
                }

                // danh sách món mới === lsvBillFoood
                // chuyển tên món -> id món
                // Example: 1, 3, 4, 7
                foreach (ListViewItem monMoi in lsvBillFood.Items)
                {
                    string tenMon = monMoi.SubItems[0].Text.ToString();
                    int idMonMoi = FoodDAO.Instance.GetFoodsByFoodName(tenMon)[0].ID;

                    BIllInfoDAO.Instance.InsertInfoBill(idHD, idMonMoi,
                                        int.Parse(monMoi.SubItems[2].Text.ToString()),
                                        float.Parse(monMoi.SubItems[3].Text.ToString()));
                }

                                              
                button3_Click(null, null);
            }


            int id1 = table.ID;
            int id2 = (cbBan.SelectedItem as Table).ID;
            table = TableDAO.Instance.SwitchTable(id1, id2 , idTk);
        }

        private void cbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void cbLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiHoaDon.Text == "Ngồi lại")
            {
                cbBan.Text = table.Tenban;
                cbBan.Enabled = false;
            }
            else
            {
                cbBan.Enabled = true;
                LoadAddTable();
            }
            Enable_btnXacNhan();
        }



        private void dtgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdMon = Convert.ToInt32(dtgvMon.CurrentRow.Cells[0].Value.ToString());

            List<Food> listBillInfo = FoodDAO.Instance.GetFoodByCategoryID(IdMon);
            foreach (var item in listBillInfo)
            {
                foreach (ListViewItem i in lsvBillFood.Items)
                {
                    if (i.Text == item.TenMon.ToString())
                    {
                        nudSoluong.Value = Convert.ToInt32(i.SubItems[2].Text.ToString());
                        break;
                    }
                    int index = lsvBillFood.Items.Count - 1;
                    if (lsvBillFood.Items[index] == i)
                    {
                        nudSoluong.Value = 0;
                    }
                }
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvMon.DataSource = SearchFoodByName(txbSearch.Text);
        }

        private void cbBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chuyenBan = int.Parse(cbBan.SelectedValue.ToString());
            }
            catch (Exception err)
            {

                Table defaultTable = (Table)cbBan.Items[0];
                chuyenBan = defaultTable.ID;
            }
        }

        private void nudSoluong_ValueChanged(object sender, EventArgs e)
        {
            int soluong = int.Parse(nudSoluong.Value.ToString());
            tongtien = 0;
            if (soluong > 0)
            {
                List<Food> listBillInfo = FoodDAO.Instance.GetFoodByCategoryID(IdMon);
                foreach (var item in listBillInfo)
                {
                    ListViewItem lsvItem = new ListViewItem(item.TenMon.ToString());
                    lsvItem.SubItems.Add(item.GiaTien.ToString());
                    lsvItem.SubItems.Add(soluong.ToString());
                    float thanhTien = item.GiaTien * soluong;
                    lsvItem.SubItems.Add(thanhTien.ToString());

                    foreach (ListViewItem i in lsvBillFood.Items)
                    {
                        if (i.Text == item.TenMon.ToString())
                        {
                            lsvBillFood.Items.Remove(i);
                        }
                    }
                    lsvItem.Name = item.ID.ToString();
                    lsvItem.Tag = new Menu(item.TenMon, item.GiaTien, soluong, thanhTien);
                    lsvBillFood.Items.Add(lsvItem);
                }
            }
            else
            {
                List<Food> listBillInfo = FoodDAO.Instance.GetFoodByCategoryID(IdMon);
                foreach (var item in listBillInfo)
                {
                    foreach (ListViewItem i in lsvBillFood.Items)
                    {
                        if (i.Text == item.TenMon.ToString())
                        {
                            lsvBillFood.Items.Remove(i);
                        }
                    }
                }
            }

            // Ghi tong tien 
            foreach (ListViewItem i in lsvBillFood.Items)
            {
                tongtien += float.Parse(i.SubItems[3].Text.ToString());
            }

            lbPrice.Text = tongtien.ToString("N0");
            Enable_btnXacNhan();
        }

        private void lsvBillFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListView).Items.Count > 0)
            {
                string tenMon = (sender as ListView).Items[0].SubItems[0].Text.ToString();
                var listFood = FoodDAO.Instance.GetFoodsByFoodName(tenMon);
                IdMon = listFood[0].ID;
                nudSoluong.Value = decimal.Parse((sender as ListView).Items[0].SubItems[2].Text.ToString());

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text == null || txbSearch.Text == "")
            {
                txbSearch.ForeColor = Color.Gray;
                txbSearch.Text = "Tìm kiếm";
            }
            else
            {
                txbSearch.ForeColor = Color.Black;
                txbSearch.Text = "";
            }
        }
    }
    #endregion
}
