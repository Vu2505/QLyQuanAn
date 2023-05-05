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
    public partial class fNhanVien : Form
    {

        BindingSource nhanvienlist = new BindingSource();
        public fNhanVien()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvListNhanVien.DataSource = nhanvienlist;
            LoadListNhanVien();
        }

        void LoadListNhanVien()
        {
            nhanvienlist.DataSource = NhanVienDAO.Instance.GetListNhanVien();
            AddNhanVienBinding();
        }

        void AddNhanVienBinding()
        {
            DeleteNhanVienBinding();
            txbIDNV.DataBindings.Add(new Binding("Text", dtgvListNhanVien.DataSource, "MaNV"));
            txbNameNV.DataBindings.Add(new Binding("Text", dtgvListNhanVien.DataSource, "TenNhanVien", true, DataSourceUpdateMode.Never));
            cbxGioiTinhNV.DataBindings.Add(new Binding("Text", dtgvListNhanVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txbCCCDNV.DataBindings.Add(new Binding("Text", dtgvListNhanVien.DataSource, "CCCD", true, DataSourceUpdateMode.Never));
            txbSDTNV.DataBindings.Add(new Binding("Text", dtgvListNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txbDiaChiNV.DataBindings.Add(new Binding("Text", dtgvListNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            cbxTrangThaiNV.DataBindings.Add(new Binding("Text", dtgvListNhanVien.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
            //LoadListMonAn();
        }

        void DeleteNhanVienBinding()
        {
            txbIDNV.DataBindings.Clear();
            txbNameNV.DataBindings.Clear();
            cbxGioiTinhNV.DataBindings.Clear();
            txbCCCDNV.DataBindings.Clear();
            txbSDTNV.DataBindings.Clear();
            txbDiaChiNV.DataBindings.Clear();
            cbxTrangThaiNV.DataBindings.Clear();
            //LoadListMonAn();
        }

        List<NhanVien> SearchNhanVienByName(string name)
        {
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.SearchNhanVienByName(name);
            return listNhanVien;

        }

        private void btnSearchNhanVien_TextChanged(object sender, EventArgs e)
        {
            nhanvienlist.DataSource = SearchNhanVienByName(txbSearchNhanVien.Text);
        }


        private void btnInsertNV_Click(object sender, EventArgs e)
        {
            DeleteNhanVienBinding();
            txbNameNV.Enabled = true;
            cbxGioiTinhNV.Enabled = true;
            txbCCCDNV.Enabled = true;
            txbSDTNV.Enabled = true;
            txbDiaChiNV.Enabled = true;
            cbxTrangThaiNV.Enabled = true;

            txbIDNV.Clear();
            txbNameNV.Clear();
            txbCCCDNV.Clear();
            txbSDTNV.Clear();
            txbDiaChiNV.Clear();
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            txbNameNV.Enabled = true;
            cbxGioiTinhNV.Enabled = true;
            txbCCCDNV.Enabled = true;
            txbSDTNV.Enabled = true;
            txbDiaChiNV.Enabled = true;
            cbxTrangThaiNV.Enabled = true;
        }

        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            string name = txbNameNV.Text;
            string gioitinh = cbxGioiTinhNV.Text;
            string cccd = txbCCCDNV.Text;
            string sdt = txbSDTNV.Text;
            string diachi = txbDiaChiNV.Text;
            string trangthai = cbxTrangThaiNV.Text;

            if (txbIDNV == null || txbIDNV.Text == "")
            {
                if (NhanVienDAO.Instance.InsertNhanVien(name, gioitinh, cccd, sdt, diachi, trangthai))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    LoadListNhanVien();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên");
                }
            }
            else
            {
                int id = Convert.ToInt32(txbIDNV.Text);
                if (NhanVienDAO.Instance.UpdateNhanVien(id, name, gioitinh, cccd, sdt, diachi, trangthai))
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                    LoadListNhanVien();
                }
                else
                {
                    MessageBox.Show("Lỗi khi Sửa nhân viên");
                }
            }

            LoadListNhanVien();
        }

        private void btnAnBatNhanVien_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDNV.Text);

            if (cbxTrangThaiNV.Text == "Thôi việc")
            {
                NhanVienDAO.Instance.UpdateBatTTNhanVien(id);
            }
            else
            {
                NhanVienDAO.Instance.UpdateTatTTNhanVien(id);
            }
            LoadListNhanVien();
        }

        
    }
}
