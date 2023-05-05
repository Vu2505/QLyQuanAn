using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 200;
        public static int TableHeight = 200;


        private TableDAO() {}


        public Table SwitchTable(int id1, int id2, int IdTK)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idtable1 , @idtable2 , @idtaikhoan ", new object[] {id1 , id2 , IdTK});
            return new Table(DataProvider.Instance.ExecuteQuery("Select * from Ban where IdBan = " + id2).Rows[0]);
        }
        
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public List<Table> LoadAddTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * From Ban where TinhTrang = 0");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public int UpdateTinhTrangBan(int idBan)
        {
            string query = "UPDATE Ban " +
                "SET TinhTrang = 1 " +
                "WHERE IdBan = " + idBan;

            return DataProvider.Instance.ExecuteNonQuery(query);
        }


        public List<Table> SearchTableByName(string name)
        {

            List<Table> list = new List<Table>();
            string query = string.Format("select * from dbo.Ban where TenBan like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
            }

            return list;
        }

        public bool InsertTable(string name, int tinhtrang, string ghichu)
        {
            string query = string.Format("insert into dbo.Ban (TenBan,TinhTrang,GhiChu)" +
                         " values (N'{0}',{1},N'{2}')", name, tinhtrang, ghichu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(int idtable, string name, int tinhtrang, string ghichu)
        {
            string query = string.Format("Update dbo.Ban " +
                         " set TenBan =N'{0}' , TinhTrang = {1}, GhiChu =N'{2}'" +
                         "where IdBan ={3} ", name, tinhtrang, ghichu, idtable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool UpdateBatTinhTrangTable(int IdBan)
        {
            string query = string.Format("Update dbo.Ban " +
                         " set TinhTrang = 1" +
                         "where IdBan ={0} ", IdBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTatTinhTrangTable(int IdBan)
        {
            string query = string.Format("Update dbo.Ban " +
                         " set TinhTrang = 0" +
                         "where IdBan ={0} ", IdBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
