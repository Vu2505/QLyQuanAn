using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { Instance = value; }
        }

        private AccountDAO() { }

        public Account Login(string userName, string passWord)
        {
            string query = "USP_Login @username , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName,passWord});
            return new Account(result.Rows[0]);
        }

        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();
            string query = "select * from TaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }


        public List<Account> SearchAccountByName(string name)
        {

            List<Account> list = new List<Account>();
            string query = string.Format("select * from TaiKhoan where TenNV like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }



        public bool InsertAccount(string TenNV, string Username, string Matkhau, int LoaiTaiKhoan, int TinhTrang, string GhiChu)
        {
            string query = string.Format("insert into TaiKhoan (TenNV,Username,Matkhau,LoaiTaiKhoan,TinhTrang,GhiChu)" +
                         " values (N'{0}',N'{1}',N'{2}',{3},{4},N'{5}')", TenNV, Username, Matkhau, LoaiTaiKhoan, TinhTrang, GhiChu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(int IdTK, string TenNV, string Username, string Matkhau, int LoaiTaiKhoan, int TinhTrang, string GhiChu)
        {
            string query = string.Format("Update dbo.TaiKhoan " +
                         " set TenNV =N'{0}' , Username = N'{1}', Matkhau=N'{2}', LoaiTaiKhoan={3}, TinhTrang ={4}, GhiChu =N'{5}'" +
                         "where IdTK ={6} ", TenNV, Username, Matkhau, LoaiTaiKhoan, TinhTrang, GhiChu, IdTK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateBatTinhTrangAccount(int IdTK)
        {
            string query = string.Format("Update dbo.TaiKhoan " +
                         " set TinhTrang = 1" +
                         "where IdTK ={0} ", IdTK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTatTinhTrangAccount(int IdTK)
        {
            string query = string.Format("Update dbo.TaiKhoan " +
                         " set TinhTrang = 0" +
                         "where IdTK ={0} ", IdTK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool UpdatePassAccount( string username, string matkhau, string matkhaumoi)
        {
            string query = string.Format("SP_Update_Pass @Username , @OldPass , @NewPass");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, matkhau, matkhaumoi});
            return result > 0;
        }

        public bool ResetUpdatePassAccount(string username, string matkhaumoi)
        {
            string query = string.Format("SP_ResetUpdate_Pass @Username , @NewPass");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username , matkhaumoi });
            return result > 0;
        }

        public bool UpdateResetPassWordAccount(int IdTK)
        {
            string query = string.Format("Update dbo.TaiKhoan " +
                         " set LoaiTaiKhoan = 2 , Matkhau = '' " +
                         "where IdTK ={0} ", IdTK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
