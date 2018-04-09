using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WholesaleRaja.Website.Account
{
    public partial class AddRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setRolesDatasource();
        }

        protected void btnAddRole_Click(object sender, EventArgs e)
        {
            if (!Roles.RoleExists(txtRoleName.Text))
            {
                Roles.CreateRole(txtRoleName.Text);
                setRolesDatasource();
            }
        }

        private void setRolesDatasource()
        {
            grvRoles.DataSource = WholesaleRaja.Accounts.Helpers.UserHelper.GetRoleDetails();
            grvRoles.DataBind();
        }
        
    }
}