using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WholesaleRaja.Products.Helpers;

namespace WholesaleRaja.Products.UserControls
{
    public partial class ManageCategories : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetAllCategoryDetails()
        {
            
        }

        protected void cbManageCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbManageCategories.SelectedValue== "ViewCategoryInfo")
            {
                phCategoryInfo.Visible = true;
                phAddCategory.Visible = false;
                phAddSubcategory.Visible = false;
                grvCategoryDetails.DataSource = ProductHelper.GetAllCategoryDetails();
                grvCategoryDetails.DataBind();
            }
            else if (cbManageCategories.SelectedValue == "AddCategory")
            {
                phCategoryInfo.Visible = false;
                phAddCategory.Visible = true;
                phAddSubcategory.Visible = false;
                
            }
            else if (cbManageCategories.SelectedValue == "AddSubcategory")
            {
                phCategoryInfo.Visible = false;
                phAddCategory.Visible = false;
                phAddSubcategory.Visible = true;
                ddlCategory.DataSource = ProductHelper.GetAllCategoryDetails();
                ddlCategory.DataTextField = "CategoryName";
                ddlCategory.DataValueField = "CategoryId";
                ddlCategory.DataBind();
                ddlCategory.Items.Insert(0, "--Select--");
            }
        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            bool categoryAdded = ProductHelper.AddCategory(txtCategoryName.Text, Membership.GetUser().UserName, txtCategorySeoTitle.Text, txtCategorySeoDescription.Text, txtCategorySeoMetaKeywords.Text);
            if (categoryAdded)
            {
                lblCategoryStatus.Text = "Category Added";
                lblCategoryStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblCategoryStatus.Text = "Category Addition Failed";
                lblCategoryStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnAddSubcategory_Click(object sender, EventArgs e)
        {
            string parentCategory = ddlCategory.SelectedValue;
            int parentCategoryId;
            if (int.TryParse(parentCategory, out parentCategoryId))
            {
                bool subcategoryAdded = ProductHelper.AddSubcategory(parentCategoryId, Membership.GetUser().UserName, txtSubcategory.Text, txtSubCategorySeoTitle.Text, txtSubCategorySeoDescription.Text, txtSubCategorySeoMetaKeywords.Text);
                if (subcategoryAdded)
                {
                    lblSubCategoryStatus.Text = "Subcategory Added Successfully";
                    lblSubCategoryStatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblSubCategoryStatus.Text = "Subcategory Addition Failed";
                    lblSubCategoryStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblSubCategoryStatus.Text = "Parent Category Id couldn't be parsed";
                lblSubCategoryStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategory.SelectedValue == "--Select--")
            {
                lblSubCategoryStatus.Text = "Please select a category";
                lblSubCategoryStatus.ForeColor = System.Drawing.Color.Red;
                grvSubcategory.Visible = false;
                return;
            }
            string parentCategory = ddlCategory.SelectedValue;
            int parentCategoryId;
            if (int.TryParse(parentCategory, out parentCategoryId))
            {
                grvSubcategory.DataSource = ProductHelper.GetSubCategory(parentCategoryId);
                grvSubcategory.DataBind();
                grvSubcategory.Visible = true;
            }
        }
    }
}