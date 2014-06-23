using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Utility
{
    public class clsDatabase
    {
        SqlConnection Conn;
        SqlCommand Cmd;
        String ConnPath;
        SqlDataReader Resultset;
        Boolean result = false;

        public Boolean ConnectDatabase()
        {
            try
            {
                ConnPath = "Server=localhost;uid=sa;password=password@1;database=Fooddb;";
                Conn = new SqlConnection(ConnPath);
                Conn.Open();
                //result = true;
                return true;
            }
            catch (Exception e)
            {
                //result = false;
                return false;
            }
        }
        //ใช้ในการ เพิ่ม ลบ แก้ไข
        public Boolean ExecData(String sql)
        {
            try
            {
                if (this.ConnectDatabase() == true)
                {
                    Cmd = new SqlCommand(sql, Conn);
                    Cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //ใช้ในการค้นหาข้อมูล
        public SqlDataReader ExecDataSearch(String sql)
        {
                if (this.ConnectDatabase() == true)
                {
                    Cmd = new SqlCommand(sql, Conn);
                    Resultset = Cmd.ExecuteReader();
                }
                return Resultset;
        }
    }
}