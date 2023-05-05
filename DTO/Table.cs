using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DTO
{
    public class Table
    {
        private Table(int id,string tenban, int tinhtrang, string ghichu)
        {
            this.ID = id;
            this.Tenban = tenban;
            this.Tinhtrang = tinhtrang;
            this.Ghichu = ghichu;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["IdBan"];
            this.Tenban = row["TenBan"].ToString();
            this.Tinhtrang = (int)row["TinhTrang"];
            this.Ghichu = row["GhiChu"].ToString();
        }

        //id
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }


        //name
        private string tenban;
        public string Tenban
        {
            get { return tenban; }
            set { tenban = value; }
        }

        //tinh trang
        private int tinhtrang;
        public int Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }


        //ghi chu
        private string ghichu;
        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
