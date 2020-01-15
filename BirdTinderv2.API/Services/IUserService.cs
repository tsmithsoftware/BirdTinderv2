using BirdTinderv2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdTinderv2.API.Services
{
    public interface IUserService
    {
        SystemUser Authenticate(string username, string password);
    }
}
