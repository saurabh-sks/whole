using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI.WebControls;
using WholesaleRaja.Accounts.Models;
using WholesaleRaja.Database;

namespace WholesaleRaja.Accounts.Helpers
{
    public class UserHelper
    {

        public static bool IsUserLoggedIn()
        {
            return HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity.IsAuthenticated;
        }

        /// <summary>
        /// Get User Profile from Database
        /// </summary>
        /// <param name="userName">UserName</param>
        /// <returns>UserProfile with all details</returns>
        private static UserProfile GetUserProfile(string userName)
        {
            // If input userName is blank or the logged in user is 
            if (string.IsNullOrWhiteSpace(userName))
            {
                return null;
            }
            else
            {
                userName = userName.ToLower();
            }

            UserProfile userProfile = new UserProfile();
            WSR_UserInfo userInfo = new WSR_UserInfo();
            List<aspnet_Roles> allRoles = new List<aspnet_Roles>();
            List<vw_aspnet_UsersInRoles> allUserRoles = new List<vw_aspnet_UsersInRoles>();
            List<string> selectedRoles = new List<string>();

            // Get all table values for the given user
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                userInfo = db.WSR_UserInfo.Where(x => x.UserName == userName).FirstOrDefault();
                allRoles = db.aspnet_Roles.ToList();
                allUserRoles = db.vw_aspnet_UsersInRoles.Where(x => x.UserId == userInfo.UserId).ToList();
            }

            // Get all Role Names for the user and add in the List of selected Roles
            foreach (var userRole in allUserRoles)
            {
                string roleName = allRoles.Where(x => x.RoleId == userRole.RoleId).Select(y => y.RoleName).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(roleName))
                {
                    selectedRoles.Add(roleName);
                }
            }
            userProfile.UserInformation = userInfo;
            userProfile.UserRoles = selectedRoles;
            return userProfile;
        }

        public static void SetUserSession(UserProfile userProfile)
        {
            if (userProfile != null && userProfile.UserInformation != null && !string.IsNullOrWhiteSpace(userProfile.UserInformation.UserName))
            {
                HttpContext.Current.Session["user-" + userProfile.UserInformation.UserName.ToLower()] = userProfile;
            }
        }

        public static UserProfile GetUser()
        {
            // If user is not logged in or the username is blank then return null
            if (!IsUserLoggedIn() || string.IsNullOrWhiteSpace(GetUserName()))
            {
                return null;
            }
            else
            {
                return GetUser(GetUserName());
            }
        }
        public static UserProfile GetUser(string userName)
        {
            //if (string.IsNullOrWhiteSpace(userName))
            //{
            //    if (!HttpContext.Current.User.Identity.IsAuthenticated || string.IsNullOrWhiteSpace(Environment.UserName))
            //    {
            //        return null;
            //    }
            //    else
            //    {
            //        userName = Environment.UserName.ToLower();
            //    }
            //}
            //else
            //{
            userName = userName.ToLower();
            //}

            UserProfile userProfile = new UserProfile();
            if (HttpContext.Current.Session["user-" + userName] != null)
            {
                userProfile = HttpContext.Current.Session["user-" + userName] as UserProfile;
            }

            if (userProfile == null || userProfile.UserInformation == null || string.IsNullOrWhiteSpace(userProfile.UserInformation.UserName))
            {
                userProfile = GetUserProfile(userName);
                SetUserSession(userProfile);
            }
            return userProfile;
        }

        public static string GetUserName()
        {
            return Membership.GetUser().UserName;
            //string userId = Membership.GetUser().ProviderUserKey.ToString();
            //return GetUserNameByUserId(userId);
        }

        public static string GetUserNameByUserId(string userId)
        {
            string userName;
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                userName = db.aspnet_Users.Where(x => x.UserId.ToString().ToLower() == userId.ToLower()).Select(y => y.UserName).FirstOrDefault();
            }
            return userName;
        }

        public static List<RoleDetails> GetRoleDetails()
        {
            List<RoleDetails> roleDetails = new List<RoleDetails>();
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                roleDetails = db.aspnet_Roles.Select(x => new RoleDetails
                {
                    RoleId = x.RoleId.ToString(),
                    RoleName = x.RoleName,
                    RoleDescription = x.Description

                }).ToList();
            }

            return roleDetails;
        }

        public static void UpdateUserDetailsOnRegistration(string userName)
        {
            aspnet_Membership userMembership = new aspnet_Membership();
            aspnet_Users aspUser = new aspnet_Users();
            WSR_UserInfo newUser = new WSR_UserInfo();
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                aspUser = db.aspnet_Users.Where(x => x.LoweredUserName == userName.ToLower()).FirstOrDefault();
                userMembership = db.aspnet_Membership.Where(x => x.UserId == aspUser.UserId).FirstOrDefault();
                if (aspUser != null && userMembership != null && aspUser.UserName.ToLower() == userName.ToLower() && aspUser.UserId == userMembership.UserId)
                {
                    newUser.UserId = aspUser.UserId;
                    newUser.UserName = aspUser.UserName;
                    newUser.Email = userMembership.Email;

                    db.WSR_UserInfo.Add(newUser);
                    db.SaveChanges();
                }
            }

        }

        public static List<ListItem> GetAllUsers()
        {
            List<aspnet_Users> users = new List<aspnet_Users>();
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                users = db.aspnet_Users.ToList();
            }

            List<ListItem> listOfUsers = new List<ListItem>();
            foreach (var eachUser in users)
            {
                ListItem li = new ListItem();
                li.Text = eachUser.UserName;
                li.Value = eachUser.UserId.ToString();
                listOfUsers.Add(li);
            }
            return listOfUsers;
        }

        public static List<aspnet_Roles> GetAllRoles()
        {
            List<aspnet_Roles> roles = new List<aspnet_Roles>();
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                roles = db.aspnet_Roles.ToList();
            }
            return roles;
        }

        public static List<ListItem> GetUserRoles(Guid userId)
        {
            List<ListItem> userRoles = new List<ListItem>();
            List<Guid> userRoleIds = new List<Guid>();
            List<aspnet_Roles> allRoles = GetAllRoles();

            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                userRoleIds = db.vw_aspnet_UsersInRoles.Where(x => x.UserId == userId).Select(y => y.RoleId).ToList();
            }

            foreach (var eachRole in allRoles)
            {
                ListItem li = new ListItem();
                li.Text = eachRole.RoleName;
                li.Value = eachRole.RoleId.ToString();
                li.Selected = userRoleIds.Where(x => x == eachRole.RoleId).Any();
                userRoles.Add(li);
            }

            return userRoles;
        }

        public static void AddRolesToUser(Guid userId, List<string> roleIds)
        {
            string roles = string.Join(",", roleIds);
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                db.WSR_Delete_And_Add_Roles_To_User(userId, roles);
            }
        }

    }
}