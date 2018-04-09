using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WholesaleRaja.Database;

namespace WholesaleRaja.Accounts.Models
{
    public class UserProfile
    {
        public WSR_UserInfo UserInformation { get; set; }
        public List<string> UserRoles { get; set; }
    }
}