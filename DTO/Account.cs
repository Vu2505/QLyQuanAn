using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DTO
{
    public class Account
    {
        //        create table TaiKhoan
        //(
        //   IdTK int identity primary key,
        //   TenNV nvarchar(max) not null,
        //   Username nvarchar(max) not null,
        //   Matkhau nvarchar(max) not null,
        //   LoaiTaiKhoan int default 0 not null,  --1: admin, 0:nhanvien
        //   TinhTrang int default 1 not null,
        //   GhiChu nvarchar(max),
        //)

        public Account()
        {

        }

        public Account(int idTK, string tenNV, string username, string matkhau ,int loaiTaiKhoan,int tinhTrang ,string ghiChu)
        {
            this.IdTK = idTK;
            this.TenNV = tenNV;
            this.Username = username;
            this.Matkhau = matkhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
            this.TinhTrang = tinhTrang;
            this.GhiChu = ghiChu;
        }

        public Account(DataRow row)
        {
            this.IdTK = (int)row["IdTK"];
            this.TenNV = row["TenNV"].ToString();
            this.Username = row["Username"].ToString();
            this.Matkhau = row["Matkhau"].ToString();
            this.LoaiTaiKhoan = (int)row["LoaiTaiKhoan"];
            this.TinhTrang = (int)row["TinhTrang"];
            this.GhiChu = row["GhiChu"].ToString();
        }

        //idnhanvien
        private int idTK;
        public int IdTK
        {
            get { return idTK; }
            set { idTK = value; }
        }

        //tennhanvien
        private string tenNV;
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        //username
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        //matkhau
        private string matkhau;
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        //loaitaikhoan
        private int loaiTaiKhoan;
        public int LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }

        //tinhtrang
        private int tinhTrang;
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        //ghichu
        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

    }
}
