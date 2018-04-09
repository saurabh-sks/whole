﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WholesaleRaja.Accounts.Helpers;
using WholesaleRaja.Accounts.Models;
using WholesaleRaja.Database;

namespace WholesaleRaja.Website.Account
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

            txtCity.Text = userprofile.UserInformation.City;
            txtState.Text = userprofile.UserInformation.State;
            txtCountry.Text = userprofile.UserInformation.Country;
            txtPostalCode.Text = userprofile.UserInformation.PinCode;
        }
    }
}