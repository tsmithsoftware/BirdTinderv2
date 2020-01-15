using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdTinderv2.API.Models;
using BirdTinderv2.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BirdTinderv2.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);

            if (user == null) return BadRequest(new { message = "Username or password incorrect." });

            return Ok(user);
        }

    }
}
