using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using BAL;
using Utility;
using System.Data;
using System.Data.SqlClient;

namespace My3tier
{
    public partial class Food : System.Web.UI.Page
    {
        clsFoodBAL objFoodBAL = new clsFoodBAL();
        clsFood objFood = new clsFood();

        clsCategoryBAL objCategoryBAL = new clsCategoryBAL();
        clsFood_category objFoodCategory = new clsFood_category();

        Boolean result = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlDataReader dr;
                dr = objCategoryBAL.SearchFoodcategory(objFoodCategory);
                drpcategoryfood.DataSource = dr;
                drpcategoryfood.DataTextField = "food_category_name";
                drpcategoryfood.DataValueField = "food_category_code";
                drpcategoryfood.DataBind();
            }
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            objFood.Food_code = txtfoodcode.Text;
            objFood.Food_name = txtfoodname.Text;
           // objFood.Food_category_code = objFoodCategory.Food_category_code;
            objFood.Food_category_code = drpcategoryfood.SelectedItem.Value;

            objFood.price = Convert.ToInt32(txtprice.Text);
            

            if (objFoodBAL.CheckValidate(objFood) == true)
            {
                lblmassage.Text = "กรุณาป้อนข้อมูลให้ครบถ้วน";
            }
            else
            {
                if (objFoodBAL.SaveFood(objFood) == true)
                {
                    lblmassage.Text = "บันทึกข้อมูลเรียบร้อย";
                }
                else
                {
                    lblmassage.Text = "บันทึกข้อมูลไม่เรียบร้อย";
                }
                /*lblmassage.Text = "";
                txtfoodcode.Text = "";
                txtfoodname.Text = "";
                txtfoodcode.Focus();*/

               // result = objFoodBAL.SaveFood(objFood);
               /* if (result == true)
                {
                    lblmassage.Text = "บันทึกข้อมูลเรียบร้อย";
                }
                else
                {
                    lblmassage.Text = "";
                }*/
            }
        }
        protected void btnsearch_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            dr = objFoodBAL.SearchFood();
            grdfood.DataSource = dr;
            grdfood.DataBind();
        }
        protected void btnserchbyname_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            objFood.Food_name = txtfoodname.Text;
            dr = objFoodBAL.SearchFoodByName(objFood);
            grdfood.DataSource = dr;
            grdfood.DataBind();
        }
        protected void btntest_Click(object sender, EventArgs e)
        {
           
        }
        protected void btndelete_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r in grdfood.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkrow = (r.Cells[0].FindControl("chkrow") as CheckBox);
                    if (chkrow.Checked == true)
                    {
                       objFood.Food_code =  r.Cells[1].Text;
                       if (objFoodBAL.deletefood(objFood) == true)
                       {
                           lblmassage.Text = "ลบข้อมูลเรียบร้อย";
                       }
                    }
                }
            }
        }
    }
}