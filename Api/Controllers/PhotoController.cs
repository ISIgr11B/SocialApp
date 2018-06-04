using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helpers.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class PhotoController : Controller
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string userLogin, string ownerLogin)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string userLogin, string ownerLogin,int index)
        {
            return Ok();
        }

        // POST api/<controller>
        [HttpPost("{id}")]
        public void Post(string userLogin,[FromBody]PhotoModel value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(string userLogin, int index, [FromBody]PhotoModel value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(string userLogin, int index)
        {
        }
    }
}
