using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

//ดึง class ทั้งหมดใน BO มาใช้
using BO;
//ดึง class ทั้งหมดใน Utility มาใช้
using Utility;

namespace DAL
{
    public class clsFood_categoryDAL

    {
        //เพิ่มข้อมูลประเภทอาหาร
        String sql;

        Boolean result = false; //แบบที่ 2
        // ปรพกาศ class Database ที่จะเรียกใช้
        clsDatabase objDatabase = new clsDatabase();

        //การคืนค่าแบบไหน เช่น แบบ boolean, void ,String ,int
        public Boolean addFood_category(clsFood_category objcategory) 
        {
            try
            {
                sql = "Insert into Food_category values ( ";
                sql = sql + "'" + objcategory.Food_category_code + "'";
                sql = sql + ",'" + objcategory.Food_category_name + "')";

               // return objDatabase.ExecData(sql);

                result = objDatabase.ExecData(sql); 
                return result;                      
            }
            catch
            {
              //  return false;
                return result;                //แบบที่ 2
            }
        }

        //ค้นหาข้อมูลประเภทอาหาร
        public SqlDataReader getFoodcategory(clsFood_category objcategory)
        {
            SqlDataReader dr;

            sql = "select * from Food_category";

            dr = objDatabase.ExecDataSearch(sql);
            return dr;
            
        }

        //ค้นหาข้อมูลตามประเภทอาหาร
        public SqlDataReader getFoodcategoryByname(clsFood_category objcategory)
        {
            SqlDataReader dr;

            sql = "select * from Food_category";
            sql = sql + " where Food_category_name like '%" + objcategory.Food_category_name + "%'";


            dr = objDatabase.ExecDataSearch(sql);
            return dr;

        }
    }
}