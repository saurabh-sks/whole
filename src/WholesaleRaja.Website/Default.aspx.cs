using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WholesaleRaja.Website
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Home Page hai mera";
            Page.MetaDescription = "Meta Description";
            Page.MetaKeywords = "Meta Keywords";
        }
    }
}