using BirdTinderv2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdTinderv2.API.Helpers
{
    public static class ExtensionMethods
    {
        public static SystemUser WithoutPassword(this SystemUser user)
        {
            user.Password = null;
            return user;
        }
        public static IEnumerable<SystemUser> WithoutPasswords(this IEnumerable<SystemUser> users)
        {
            return users.Select(user => user.WithoutPassword());
        }
    }
}
