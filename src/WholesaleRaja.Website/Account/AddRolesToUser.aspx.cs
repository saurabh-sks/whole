using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WholesaleRaja.Accounts.Helpers;

namespace WholesaleRaja.Website.Account
{
    public partial class AddRolesToUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetUserDataSource();
            }
        }

        protected void btnAddRole_Click(object sender, EventArgs e)
        {
            List<string> selectedRoles = cblRolesList.Items.Cast<ListItem>().Where(li => li.Selected).Select(x => x.Value).ToList();
            UserHelper.AddRolesToUser(new Guid(ddlUserList.SelectedValue), selectedRoles);
        }

        protected void ddlUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update selected roles list of user
            List<ListItem> list = UserHelper.GetUserRoles(new Guid(ddlUserList.SelectedValue));
            cblRolesList.DataSource = list;
            cblRolesList.DataBind();
            foreach (ListItem cbItem in cblRolesList.Items)
            {
                cbItem.Selected = list.Where(x => x.Value == cbItem.Value).Select(y => y.Selected).FirstOrDefault();
            }
        }

        private void SetUserDataSource()
        {
            ddlUserList.DataSource = UserHelper.GetAllUsers();
            ddlUserList.DataBind();
            ddlUserList.Items.Insert(0, new ListItem("--Select--", "--Select--"));
        }
    }
}