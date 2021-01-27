using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreAppBackEnd.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // GET: api/<ApiController>
        [HttpGet("get")]
        public IEnumerable<string> GetL()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiController>
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(Model value)
        {
            if(value != null)
            {
                return this.Ok(new string[] { "sumit", "chourasia" });
            }
            return this.Ok(new string[] { "value1", "value2" });
        }

        // PUT api/<ApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public class Model
        {
           public string email { get; set; }
           public string password { get; set; }
        }
    }
}
