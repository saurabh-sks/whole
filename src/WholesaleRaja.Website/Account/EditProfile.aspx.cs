using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WholesaleRaja.Accounts.Helpers;
using WholesaleRaja.Accounts.Models;
using WholesaleRaja.Website.Helpers;

namespace WholesaleRaja.Website.Account
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserProfile userprofile = UserHelper.GetUser(UserHelper.GetUserName());
                txtUserName.Text = userprofile.UserInformation.UserName;
                txtFirstName.Text = userprofile.UserInformation.FirstName;
                txtMiddleName.Text = userprofile.UserInformation.MiddleName;
                txtLastName.Text = userprofile.UserInformation.LastName;

                txtEmail.Text = userprofile.UserInformation.Email;
                txtMobile.Text = userprofile.UserInformation.MobileNumber;
                txtAddressLine1.Text = userprofile.UserInformation.AddressLine1;
                txtAddressLine2.Text = userprofile.UserInformation.AddressLine2;

                //txtCity.Text = userprofile.UserInformation.City;
                //txtState.Text = userprofile.UserInformation.State;
                txtCountry.Text = userprofile.UserInformation.Country;
                txtPostalCode.Text = userprofile.UserInformation.PinCode;

                ddlState.DataSource = CommonHelper.GetState(CommonHelper.GetCountryCodeForIndia());
                ddlState.DataBind();
                if (!(ddlState.SelectedValue == "--Select--"))
                {
                    ddlCity.DataSource = CommonHelper.GetCity(int.Parse(ddlState.SelectedValue));
                    ddlCity.DataBind();
                    ddlCity.Items.Insert(0, new ListItem("--Select--", "--Select--"));
                }
            }
            
            
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(ddlState.SelectedValue == "--Select--"))
            {
                ddlCity.DataSource = CommonHelper.GetCity(int.Parse(ddlState.SelectedValue));
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, new ListItem("--Select--", "--Select--"));
            }
        }
    }
}