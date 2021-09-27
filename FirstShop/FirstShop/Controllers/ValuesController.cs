using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstShop.Models.Classes;

namespace FirstShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            Users users = new Users()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "fn1",
                    LastName = "ln1",
                    Birthday = new DateTime(1995, 9, 5),
                    Login = "login1",
                    Email = "email1",
                    Password = "password1",
                    Status = Models.Iterfaces.Status.User
                },
                new User()
                {
                    Id = 2,
                    FirstName = "fn2",
                    LastName = "ln2",
                    Birthday = new DateTime(1995, 9, 5),
                    Login = "login2",
                    Email = "email2",
                    Password = "password2",
                    Status = Models.Iterfaces.Status.User
                }
            };

            int count;
            using(var db = new ShopContext())
            {
                count = db.Users.Count();
            }

            return count.ToString();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
