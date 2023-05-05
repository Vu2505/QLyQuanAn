using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "Select m.TenMon, m.GiaTien, bi.Soluong, m.GiaTien*bi.Soluong as Thanhtien" +
                " from dbo.ChiTietHoaDon as bi, dbo.HoaDon as b, dbo.Mon as m where bi.IdHoaDon = b.IdHD and bi.IdMon = m.IdMon and b.TinhTrang = 0 and b.SoBan = "+id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }


        public int GetIdBill(int id)
        {
            int idHD = 0; 
            string query = "select IdHD from HoaDon where TinhTrang = 0 and SoBan = " + id;

            idHD = int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
            return idHD;
        }
    }
}
