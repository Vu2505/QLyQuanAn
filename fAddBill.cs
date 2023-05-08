using QLyQuanAn.DAO;
using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLyQuanAn
{
    public partial class fAddBill : Form
    {
        float tongtien = 0;
        int idTk = Storage.Account.GetAccount().IdTK;
        public fAddBill()
        {
            InitializeComponent();
            LoadCategory();
            LoadMonAnList();
            //Storage.Display.GoFullscreen(this, false);
            //LoadCategoryIntoComboBox(cbLoaiMon);
        }

        //void LoadCategoryIntoComboBox(ComboBox cb)
        //{
        //    cb.DataSource = CategoryDAO.Instance.GetListCategory();
        //    cb.DisplayMember = "TenLoaiMon";
        //}

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


        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;

        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            if(cbLoaiMon.Text == "ALL")
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
            if(lsvBillFood.Items.Count == 0 || cbLoaiHoaDon.Text == "")
            {
                btnXacNhan.Enabled = false;
            }
            else
            {
                btnXacNhan.Enabled = true;
            }
        }

        #region Events

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void cbxLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        int idban;
        private void cbLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbLoaiHoaDon.Text == "Mang đi")
            {
                cbBan.Enabled = false;
                idban = 21;
            }
            else
            {
                cbBan.Enabled = true;
                LoadAddTable();
            }
            Enable_btnXacNhan();
        }

        private void cbBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idban = int.Parse(cbBan.SelectedValue.ToString());
            }
            catch (Exception err)
            {
                
                Table defaultTable = (Table)cbBan.Items[0];
                idban = defaultTable.ID;
            }
        }


        int IdMon;
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

        private void nudSoluong_ValueChanged(object sender, EventArgs e)
        {
            int soluong = int.Parse(nudSoluong.Value.ToString());
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
                        if(i.Text == item.TenMon.ToString())
                        {
                            lsvBillFood.Items.Remove(i);
                            tongtien -= float.Parse(i.SubItems[3].Text.ToString());
                        }
                    }
                    lsvItem.Name = item.ID.ToString();
                    lsvItem.Tag = new Menu(item.TenMon, item.GiaTien, soluong, thanhTien);
                    lsvBillFood.Items.Add(lsvItem);
                    tongtien += thanhTien;
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
                            tongtien -= float.Parse(i.SubItems[3].Text.ToString());
                        }
                    }
                }
            }

            lbPrice.Text = tongtien.ToString("N0");
            Enable_btnXacNhan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lsvBillFood.Items.Clear();
            lbPrice.Text = "0";
            nudSoluong.Value = 0;
            lbPrice.Text = "0 VNĐ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xác nhận hóa đơn hay không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                var tongtien = float.Parse(lbPrice.Text.Split(' ')[0].Replace('.', ','));
                int idHD = BillDAO.Instance.InsertBill(idban, idTk, tongtien);
                int rowsAffected = TableDAO.Instance.UpdateTinhTrangBan(idban);
                if(rowsAffected > 0)
                {
                    MessageBox.Show("Hóa đơn đã được thêm thành công");                    
                    LoadAddTable();
                }
                
                foreach (ListViewItem i in lsvBillFood.Items)
                {
                    BIllInfoDAO.Instance.InsertInfoBill(idHD, 
                        int.Parse(i.Name),
                        int.Parse(i.SubItems[2].Text.ToString()),
                        float.Parse(i.SubItems[3].Text.ToString()));
                    //MessageBox.Show(i.Name);
                }
               
                button3_Click(null, null);
            }

            
        }
        #endregion

        private void lsvBillFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListView).Items.Count > 0)
            {
                Menu m = (sender as ListView).Items[0].Tag as Menu;
                IdMon = int.Parse((sender as ListView).Items[0].Name);
                nudSoluong.Value = m.Soluong;

            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvMon.DataSource = SearchFoodByName(txbSearch.Text);
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.ForeColor = Color.Black;
            txbSearch.Text = "";
        }
    }
}
