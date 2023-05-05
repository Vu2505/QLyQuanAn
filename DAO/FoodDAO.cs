using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select * from Mon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Mon where IdMon = " +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetFoodsByFoodName(string name)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Mon where TenMon = N'" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> SearchFoodByName(string name)
        {

            List<Food> list = new List<Food>();
            string query = string.Format("select * from Mon where TenMon like N'%{0}%'",name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }


        public bool  InsertFood(string name, float giatien, int tinhtrang, int loaimon,string ghichu)
        {
            string query = string.Format( "insert into Mon (TenMon,GiaTien,TinhTrang,LoaiMon,GhiChu)" +
                         " values (N'{0}',{1},{2},{3},{4})",name, giatien, tinhtrang, loaimon,ghichu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0; 
        }

        public bool UpdateFood(int idfood, string name, float giatien, int tinhtrang, int loaimon, string ghichu)
        {
            string query = string.Format("Update dbo.Mon " +
                         " set TenMon =N'{0}' , GiaTien = {1}, TinhTrang={2}, LoaiMon={3},GhiChu =N'{4}'" +
                         "where IdMon ={5} ", name, giatien, tinhtrang, loaimon, ghichu,idfood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateBatTinhTrangFood(int IdMon)
        {
            string query = string.Format("Update dbo.Mon " +
                         " set TinhTrang = 1" +
                         "where IdMon ={0} ", IdMon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTatTinhTrangFood(int IdMon)
        {
            string query = string.Format("Update dbo.Mon " +
                         " set TinhTrang = 0" +
                         "where IdMon ={0} ", IdMon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


    }

   
}
