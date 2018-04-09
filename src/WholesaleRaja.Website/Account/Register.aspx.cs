using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WholesaleRaja.Accounts.Helpers;

namespace WholesaleRaja.Website.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            Roles.AddUserToRole(CreateUserWizard1.UserName, "Client");
            UserHelper.UpdateUserDetailsOnRegistration(CreateUserWizard1.UserName);
            UserHelper.GetUser(CreateUserWizard1.UserName);
        }
    }
}