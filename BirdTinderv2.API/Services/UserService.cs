using BirdTinderv2.API.Helpers;
using BirdTinderv2.DAL;
using BirdTinderv2.DAL.Repositories;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BirdTinderv2.API.Services
{
    public class UserService : IUserService
    {
        private static ModelContext modelContext = new ModelContext();
        private SystemUserRepo userRepo = new SystemUserRepo(modelContext);

        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public SystemUser Authenticate(string username, string password)
        {
            var user = userRepo.Get(
                x => x.Username == username &&
                x.Password == password).FirstOrDefault()
                ;

            //return null if not found
            if (user == null) return null;

            //else auth success so generate jwt token

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user.WithoutPassword();
        }

        public IEnumerable<SystemUser> getAll()
        {
            return userRepo.GetAll().WithoutPasswords();
        }
    }
}
