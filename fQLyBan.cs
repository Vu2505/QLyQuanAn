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
    public partial class fQLyBan : Form
    {
        public fQLyBan()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Method
        void LoadTable()
        {
            flpBan.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach(Table item in tableList)
            {
               int tinhtrangban = item.Tinhtrang;
               if(tinhtrangban == 1 || tinhtrangban == 0)
                {
                    Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                    btn.Text = item.Tenban + Environment.NewLine
                        + (item.Tinhtrang == 1 ? "Có khách" : "Trống");
                    btn.Click += btn_Click;
                    btn.Tag = item;

                    switch (item.Tinhtrang)
                    {
                        case 0:
                            btn.BackColor = Color.FromArgb(185, 237, 221);
                            break;
                        default:
                            btn.BackColor = Color.FromArgb(245, 243, 193);
                            break;

                    }
                    flpBan.Controls.Add(btn);
                }
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float tongTien = 0;
            foreach(Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenMon.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.Soluong.ToString());
                lsvItem.SubItems.Add(item.Thanhtien.ToString());
                lsvBill.Items.Add(lsvItem);
                tongTien += item.Thanhtien;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            lbPrice.Text = tongTien.ToString("N0", culture)+ " VND";

            if(lsvBill.Items.Count == 0)
            {
                button3.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button1.Enabled = true;
            }
            //LoadTable();
        }

        #endregion

        #region Events
        void LoadTableEvent(object sender, EventArgs e)
        {
            LoadTable();
        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag as Table;
            ShowBill(tableID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fEditBill f = new fEditBill(lsvBill.Tag as Table);
            Storage.Events.UpdateTable += LoadTableEvent;
            f.Show();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            var tongtien = double.Parse(lbPrice.Text.Split(' ')[0].Replace('.', ','));

            //double finalTotalPrice = totalPrice - (totalPrice/100)

            if(idBill != -1)
            {
                if(MessageBox.Show("Bạn có muốn thanh toán hóa đơn cho bàn " + table.Tenban 
                    + Environment.NewLine 
                    + "Tổng tiền: " + tongtien.ToString(), "Thông báo", MessageBoxButtons.OKCancel) 
                    == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, (float)tongtien);
                    ShowBill(table.ID);
                }
            }
            LoadTable();


        }
        #endregion
    }
}
