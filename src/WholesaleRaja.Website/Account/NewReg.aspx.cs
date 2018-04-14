using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WholesaleRaja.Website.Account
{
    public partial class NewReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            MembershipCreateStatus registrationStatus;
            Membership.CreateUser(txtUserName.Text, txtPassword.Text, txtEmail.Text, null, null, false, out registrationStatus);

            switch(registrationStatus)
            { 
                case MembershipCreateStatus.DuplicateEmail:
                    lblStatus.Text = "Email Id already exists. Please enter another email id";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    lblStatus.Text = "Username already exists. Please enter another username";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    break;
                case MembershipCreateStatus.InvalidUserName:
                    lblStatus.Text = "Username is invalid";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    break;
                case MembershipCreateStatus.InvalidEmail:
                    lblStatus.Text = "Email Id is invalid";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    break;
                case MembershipCreateStatus.Success:
                    lblStatus.Text = "User created";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    break;
                default:
                    lblStatus.Text = "Some Error occured. Please contact the administrator";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    break;
            }

        }

        protected void rblRegistrationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearAllControls()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
                 
        }
    }
}