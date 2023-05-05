using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DTO
{
    public class Menu
    {
        public Menu(string tenmon, float gia, int soluong, float thanhtien =0)
        {
            this.TenMon = tenmon;
            this.Gia = gia;
            this.Soluong = soluong;
            this.Thanhtien = thanhtien;
        }

        public Menu(DataRow row)
        {
            this.TenMon = row["TenMon"].ToString();
            this.Gia = (float)Convert.ToDouble(row["GiaTien"].ToString());
            this.Soluong = (int)row["Soluong"];
            this.Thanhtien = (float)Convert.ToDouble(row["Thanhtien"].ToString());
        }

        private float thanhtien;
        public float Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        private int soluong;
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private float gia;
        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }


        private string tenmon;
        public string TenMon
        {
            get { return tenmon; }
            set { tenmon = value; }
        }
    }
}
