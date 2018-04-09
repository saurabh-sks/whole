using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WholesaleRaja.Products.Models;
using WholesaleRaja.Accounts.Helpers;
using System.Web.Security;
using WholesaleRaja.Products.Helpers;

namespace WholesaleRaja.Website.ProductManagement
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!UserHelper.IsUserLoggedIn())
            {
                Response.Redirect("/");
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            decimal basePrice = decimal.Parse(txtBasePrice.Text);
            decimal salePrice = decimal.Parse(txtSalePrice.Text);
            decimal savingsAmount = basePrice - salePrice;
            int savingPercentage = int.Parse(Math.Round(savingsAmount * 100 / basePrice, 0, MidpointRounding.AwayFromZero).ToString());
            Product newProduct = new Product
            {
                Name = txtProductName.Text,
                Image = txtImagePath.Text,
                SKU = txtSku.Text,
                IsActive = cbIsActive.Checked,
                Description = txtDescription.Text,
                BasePrice = basePrice,
                SalePrice = salePrice,
                SavingsAmount = savingsAmount,
                SavingsPercentage = savingPercentage,
                SeoTitle = txtSeoTitle.Text,
                SeoDescription = txtSeoDescription.Text,
                SeoMetaKeywords = txtSeoMeta.Text,
                CreatedBy = Membership.GetUser().UserName,
                CreatedDate = DateTime.Now,

            };
            ProductHelper.AddProduct(newProduct);
        }
    }
}