using QLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLyQuanAn.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from LoaiMon ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public List<Category> GetListCategory1()
        {
            List<Category> list = new List<Category>();
            string query = "select * from LoaiMon where IdLoaiMon <> 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }


        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "select * from LoaiMon where IdLoaiMon =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                 category = new Category(item);
                return category;
            }

            return category;
        }


        public bool InsertCategoryFood(string name)
        {
            string query = string.Format("insert into LoaiMon (TenMon)" +
                         " values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategoryFood(int idloaifood, string name)
        {
            string query = string.Format("Update dbo.Mon " +
                         " set TenMon =N'{0}'" +
                         "where IdMon ={1} ", name, idloaifood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Category> SearchCategoryByName(string name)
        {

            List<Category> list = new List<Category>();
            string query = string.Format("select * from LoaiMon where TenLoaiMon like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
    }
}
