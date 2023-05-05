using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DAO
{
    class BIllInfoDAO
    {

        private static BIllInfoDAO instance;

        public static BIllInfoDAO Instance
        {
            get { if (instance == null) instance = new BIllInfoDAO(); return BIllInfoDAO.instance; }
            private set { BIllInfoDAO.instance = value; }
        }

        private BIllInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ChiTietHoaDon where IdHoaDon = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public int InsertInfoBill(int idHD, int idMon, int sl, float thanhTien)
        {
            string query = "USP_InserInfotBill @idHoaDon , @idMon , @SoLuong , @ThanhTien";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHD, idMon, sl, thanhTien });
        }

        public int KiemTraIDMonTrongBill(int idHD, int idMon)
        {
            string query = "select * from dbo.ChiTietHoaDon " +
                " where [IdHoaDon] = " + idHD +
                " AND IdMon = " + idMon;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<int> GetInfoBill(int idHD)
        {
            List<int> listBillInfo = new List<int>();

            string query = "select * from dbo.ChiTietHoaDon " +
                " where [IdHoaDon] = " + idHD;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info.IdMon);
            }

            return listBillInfo;
        }

        public int UpdateInfoBill(int idHD, int idMon, int sl, float thanhTien)
        {
            string query = "update dbo.ChiTietHoaDon " +
                "set SoLuong = " + sl + 
                ", ThanhTien = "+thanhTien +
                " where [IdHoaDon] = " + idHD +
                " AND IdMon = "+idMon;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int DeleteInfoBill(int idHD, int idMon)
        {
            string query = "delete from dbo.ChiTietHoaDon " +
                " where [IdHoaDon] = " + idHD +
                " AND IdMon = " + idMon;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
