using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SjeApi.DataAccess;
using SjeApi.Interfaces.DataAccess;
namespace SjeApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult GetAllUsers()
        {
            IUsersDbContext conn = new UsersDbContext();
            var usersList = conn.GetUsers();
            return Ok(usersList);
        }

        // GET api/values/5
        [HttpGet("{userName}/{password}")]
        public string AuthenticateUser(string userName,string password)
        {
            var userConnection = new UsersDbContext();
            var user = userConnection.GetUser(userName,password);
            if(user!=null){
                return "true";
            }
            return "false";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
