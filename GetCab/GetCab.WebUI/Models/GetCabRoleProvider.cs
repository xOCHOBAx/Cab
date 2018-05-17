using GetCab.BusinessLogicContracts;
using GetCab.CoreLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace GetCab.WebUI.Models
{
    public class GetCabRoleProvider : RoleProvider
    {
        IBusinessLogic BusinessLogic = new BusinessLogic();

        public override string[] GetRolesForUser(string username)
        {
            
            if (username.StartsWith("a", StringComparison.CurrentCultureIgnoreCase))
            {
                return new[] { "admin" };
            }
            return new[] { "user" };

        }
        public override bool IsUserInRole(string username, string roleName)
        {
            return GetUsersInRole(username).Contains(roleName);
        }

        #region Not implemented

        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }


        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}