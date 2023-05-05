using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DTO
{
    public class Category
    {
        private Category(int id, string tenLoaiMon)
        {
            this.ID = id;
            this.TenLoaiMon = tenLoaiMon;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["IdLoaiMon"];
            this.TenLoaiMon = row["TenLoaiMon"].ToString();
        }
        

        //id
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        //tenmon
        private string tenLoaiMon;
        public string TenLoaiMon
        {
            get { return tenLoaiMon; }
            set { tenLoaiMon = value; }
        }
    }
}
