using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DTO
{
    class NhanVien
    {
        public NhanVien(int maNV, string tenNhanVien, string gioiTinh, string cccd, string sdt,string diaChi, string trangThai)
        {
            this.MaNV = maNV;
            this.TenNhanVien = tenNhanVien;
            this.GioiTinh = gioiTinh;
            this.CCCD = cccd;
            this.SDT = sdt;
            this.DiaChi = diaChi;
            this.TrangThai = trangThai;
        }

        public NhanVien(DataRow row)
        {
            this.MaNV = (int)row["MaNV"];
            this.TenNhanVien = row["TenNhanVien"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.CCCD = row["CCCD"].ToString();
            this.SDT = row["SDT"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }

        //idnhanvien
        private int maNV;
        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        //tennhanvien
        private string tenNhanVien;
        public string TenNhanVien
{
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        //username
        private string gioiTinh;
        public string GioiTinh
{
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        //matkhau
        private string cccd;
        public string CCCD
        {
            get { return cccd; }
            set { cccd = value; }
        }

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        //ghichu
        private string trangThai;
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

    }
}

