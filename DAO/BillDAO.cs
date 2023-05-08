using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }
        /// <summary>
        /// thành công: bill ID
        /// thất bại :-1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        //," + "totalPrice = " + totalPrice + "
        public void CheckOut(int id, float tongtien)
        {
            string query = "UPDATE dbo.HoaDon set ThoiGianRa = GETDATE(), TinhTrang = 1,"+"tongtien = " +tongtien  +  "  where IdHD = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }


        public DataTable GetBillListByDate(DateTime checkIn,DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_ThongKeDoanhThu @checkIn , @checkOut", new object[] {checkIn, checkOut });
        }

        public float GetTotalByDate(DateTime checkIn, DateTime checkOut)
        {
            return float.Parse(DataProvider.Instance.ExecuteScalar("USP_TongDoanhThu @checkIn , @checkOut", 
                new object[] { checkIn, checkOut })
                .ToString());
        }

        public int GetUncheckBillIDByTableID(int id)
        { 
            DataTable data = DataProvider
                .Instance
                .ExecuteQuery("SELECT * FROM dbo.HoaDon where SoBan = " + id + " AND TinhTrang = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public int InsertBill(int idBan, int idTK, float tongtien)
        {
            string query = "USP_InsertBill @idTable , @idTaiKhoan , @TongTien ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { idBan, idTK, tongtien });
            int id = int.Parse(result.Rows[0]["IdHD"].ToString());
            return id;
        }

    }
}
