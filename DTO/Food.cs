using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DTO
{
    public class Food
    {
        private Food(int id, string tenMon , float giaTien, int tinhTrang,int loaiMon, string ghiChu)
        {
            this.ID = id;
            this.TenMon = tenMon;
            this.GiaTien = giaTien;
            this.TinhTrang = tinhTrang;
            this.LoaiMon = loaiMon;
            this.GhiChu = ghiChu;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["IdMon"];
            this.TenMon = row["TenMon"].ToString();
            this.GiaTien = float.Parse(row["GiaTien"].ToString());
            this.TinhTrang = (int)row["TinhTrang"];
            this.LoaiMon = (int)row["LoaiMon"];
            this.GhiChu = row["GhiChu"].ToString();
        }
        //id
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        //tenmon
        private string tenMon;
        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }

        //giatien
        private float giaTien;
        public float GiaTien
        {
            get { return giaTien; }
            set { giaTien = value; }
        }


        //trinhtrang
        private int tinhTrang;
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        //trinhtrang
        private int loaiMon;
        public int LoaiMon
        {
            get { return loaiMon; }
            set { loaiMon = value; }
        }

        //ghi chu
        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

    }
}
