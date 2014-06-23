using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BO;
using Utility;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class clsFoodDAL
    {  
        //เพิ่มข้อมูลอาหาร
        String sql;
        
        Boolean result = false;
        clsDatabase objDatabase = new clsDatabase();

        public Boolean addFood(clsFood objFood)
        {
            try
            {
                sql = "insert into food (Food_code,Food_category_code,Food_name,price) values (";
                sql = sql + "'" + objFood.Food_code + "'";
                sql = sql + ",'" + objFood.Food_category_code + "'";
                sql = sql + ",'" + objFood.Food_name + "'";
                sql = sql + ",'" + objFood.price + "')";
                result = objDatabase.ExecData(sql);
                return result;
            }
            catch
            {
              return result;
            }
        }
        //ค้นหาข้อมูลอาหาร
        public SqlDataReader getFood()
        {
            SqlDataReader dr;
            sql = "select * from Food ";
            dr = objDatabase.ExecDataSearch(sql);
            return dr;
        }
        //ค้นหาข้อมูลอาหารโดยชื่อ
        public SqlDataReader getFoodByName(clsFood objFood)
        {  
            SqlDataReader dr;
            sql = "select * from Food";
            sql = sql + " where Food_name LIKE '%" + objFood.Food_name + "%'";
            dr = objDatabase.ExecDataSearch(sql);
            return dr;
        }
        public Boolean deleteFood(clsFood objFood)
        {
            try
            {
                sql = "delete food where Food_code = ";
                sql = sql + "'" + objFood.Food_code + "'";
                result = objDatabase.ExecData(sql);
                return result;
            }
            catch
            {
                return result;
            }
        }


       
    }
}