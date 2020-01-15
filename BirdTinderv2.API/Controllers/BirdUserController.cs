using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BirdTinderv2.DAL.Repositories;
using BirdTinderv2.DAL;
//jasonwatmore.com/post/2019/10/11/aspnet-core-3-jwt-authentication-tutorial-with-example-api#authenticate-model-cs


namespace BirdTinderv2.API.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class BirdUserController : ControllerBase
    {
        private static ModelContext context = new ModelContext();
        private BirdUserRepo userRepo = new BirdUserRepo(context);

        // GET: api/BirdUser
        [HttpGet]
        public List<BirdUser> Get()
        {
            return userRepo.GetAll();
        }

        // GET: api/BirdUser/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BirdUser  
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/BirdUser/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
