using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

using BO;
using DAL;

namespace BAL
{
    public class clsCategoryBAL
    {
        clsFood_categoryDAL objCategoryDAL = new clsFood_categoryDAL();
        public Boolean Checkvalidate(clsFood_category objCategory)
        {
            if (objCategory.Food_category_code == "" || objCategory.Food_category_name == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean SaveCategory(clsFood_category objCategory)
        {
            return objCategoryDAL.addFood_category(objCategory);
        }

        public SqlDataReader SearchFoodcategory(clsFood_category objcategory)
        {
            return objCategoryDAL.getFoodcategory(objcategory);
        }

        public SqlDataReader SearchFoodcategoryByname(clsFood_category objCategory)
        {
            return objCategoryDAL.getFoodcategoryByname(objCategory);
        }
    }
}