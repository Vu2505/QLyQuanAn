using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { Instance = value; }
        }

        private NhanVienDAO() { }

        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "select * from NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanvien = new NhanVien(item);
                list.Add(nhanvien);
            }

            return list;
        }


        public List<NhanVien> SearchNhanVienByName(string name)
        {

            List<NhanVien> list = new List<NhanVien>();
            string query = string.Format("select * from NhanVien where TenNhanVien like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanvien = new NhanVien(item);
                list.Add(nhanvien);
            }

            return list;
        }

        public bool InsertNhanVien(string name, string gioitinh, string cccd, string sdt, string diachi ,string trangthai)
        {
            string query = string.Format("insert into NhanVien (TenNhanVien,GioiTinh,CCCD,SDT,DiaChi,TrangThai)" +
                         " values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", name, gioitinh, cccd, sdt, diachi, trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateNhanVien(int MaNV, string name, string gioitinh, string cccd, string sdt, string diachi, string trangthai)
        {
            string query = string.Format("Update dbo.NhanVien " +
                         " set TenNhanVien =N'{0}' , GioiTinh = N'{1}', CCCD=N'{2}', SDT=N'{3}',DiaChi =N'{4}',TrangThai =N'{5}'" +
                         "where MaNV ={6} ", name, gioitinh, cccd, sdt, diachi, trangthai, MaNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateBatTTNhanVien(int MaNV)
        {
            string query = string.Format("Update dbo.NhanVien " +
                         " set TrangThai = N'Đang làm'" +
                         "where MaNV ={0} ", MaNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTatTTNhanVien(int MaNV)
        {
            string query = string.Format("Update dbo.NhanVien " +
                         " set TrangThai = N'Thôi việc'" +
                         "where MaNV ={0} ", MaNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
