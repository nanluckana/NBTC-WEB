using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class clsFoodBAL
    {
        clsFoodDAL objFoodDAL = new clsFoodDAL();
        public Boolean CheckValidate(clsFood objFood)
        {
            if (objFood.Food_code == "" || objFood.Food_name == "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SaveFood(clsFood objFood)
        {
            return objFoodDAL.addFood(objFood);
        }
        public SqlDataReader SearchFood()
        {
            return objFoodDAL.getFood();
        }
        public SqlDataReader SearchFoodByName(clsFood objFood)
        {
            return objFoodDAL.getFoodByName(objFood);
        }
        public Boolean deletefood(clsFood objFood)
        {
            return objFoodDAL.deleteFood(objFood);
        }
    }
}