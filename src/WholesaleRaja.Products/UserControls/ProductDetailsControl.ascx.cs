using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WholesaleRaja.Products.Helpers;
using WholesaleRaja.Products.Models;

namespace WholesaleRaja.Products.UserControls
{
    public partial class ProductDetailsControl : System.Web.UI.UserControl
    {
        public Product productDetails { get; set; }
        public string ProductId { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductId = Request.QueryString["p"];
            GetProductDetails(ProductId);
        }

        private void GetProductDetails(string productId)
        {
            if (!string.IsNullOrWhiteSpace(productId))
            {
                productDetails = ProductHelper.GetProductDetails(productId);
            }

            if (productDetails != null)
            {
                SetSeoProperties();
            }
            else
            {
                // Hide the control
            }
        }

        private void SetSeoProperties()
        {
            Page.Title = productDetails.SeoTitle;
            Page.MetaDescription = productDetails.SeoDescription;
            Page.MetaKeywords = productDetails.SeoMetaKeywords;
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}