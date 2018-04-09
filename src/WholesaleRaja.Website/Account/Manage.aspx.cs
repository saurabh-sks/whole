using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WholesaleRaja.Accounts.Models;
using WholesaleRaja.Accounts.Helpers;

namespace WholesaleRaja.Website.Account
{
    public partial class Manage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!UserHelper.IsUserLoggedIn())
            {
                Response.Redirect("/");
            }
            UserProfile userProfile = UserHelper.GetUser();
            if (userProfile.UserRoles.Where(x=> x.ToLower()=="admin" || x.ToLower() == "productmanager").Any())
            {
                AdminAccountManager.Visible = true;
            }
            else
            {
                AdminAccountManager.Visible = false;
            }
        }
    }
}