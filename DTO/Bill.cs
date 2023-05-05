using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DTO
{
    public class Bill
    {
        private Bill(int id, int soban, int idTK, int tinhtrang, DateTime? thoiGianVao, DateTime? thoiGianRa, string ghichu)
        {
            this.ID = id;
            this.SoBan = soban;
            this.IdTK = idTK;
            this.TinhTrang = tinhtrang;
            this.ThoiGianVao = thoiGianVao;
            this.ThoiGianRa = thoiGianRa;
            this.GhiChu = ghichu;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["IdHD"];
            this.SoBan = (int)row["SoBan"];
            this.IdTK = (int)row["IdTK"];
            this.TinhTrang = (int)row["TinhTrang"];
            this.ThoiGianVao = (DateTime?)row["ThoiGianVao"];
            var ThoiGianRaTemp = row["ThoiGianRa"];
            if (ThoiGianRaTemp.ToString() != "")
                this.ThoiGianRa = (DateTime?)ThoiGianRaTemp;
            this.GhiChu = row["GhiChu"].ToString();
        }

        //ghi chu
        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        //thoi gian
        private DateTime? thoiGianRa;
        public DateTime? ThoiGianRa
        {
            get { return thoiGianRa; }
            set { thoiGianRa = value; }
        }

        //id
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        //tinh trang
        private int soban;
        public int SoBan
        {
            get { return soban; }
            set { soban = value; }
        }

        //name
        private int idTK;
        public int IdTK
        {
            get { return idTK; }
            set { idTK = value; }
        }

        //ghi chu
        private int tinhTrang;
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        //thoi gian
        private DateTime? thoiGianVao;
        public DateTime? ThoiGianVao
        {
            get { return thoiGianVao; }
            set { thoiGianVao = value; }
        }
    }
}
