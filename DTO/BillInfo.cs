using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DTO
{
    public class BillInfo
    {
        private BillInfo(int id, int idHoaDon, int idMon, int soluong, float thanhTien)
        {
            this.ID = id;
            this.IdHoaDon = idHoaDon;
            this.IdMon = idMon;
            this.Soluong = soluong;
            this.ThanhTien = thanhTien;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["IdInfo"];
            this.IdHoaDon = (int)row["IdHoaDon"];
            this.IdMon = (int)row["IdMon"];
            this.Soluong = (int)row["Soluong"];
            this.ThanhTien = float.Parse(row["ThanhTien"].ToString());

        }

        //id
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        //tinh trang
        private int idHoaDon;
        public int IdHoaDon
        {
            get { return idHoaDon; }
            set { idHoaDon = value; }
        }

        //name
        private int idMon;
        public int IdMon
        {
            get { return idMon; }
            set { idMon = value; }
        }


        //ghi chu
        private int soluong;
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        //ghi chu
        private float thanhTien;
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }


    }
}
