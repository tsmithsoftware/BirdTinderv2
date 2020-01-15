using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirdTinderv2.API.Models
{
    public class AuthenticateModel
    {
        [Required]
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
