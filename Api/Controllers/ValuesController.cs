using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bll.Models;
using Bll.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ValuesController : BaseController
    {
        public ValuesController(IServiceFactory serviceFactory) : base(serviceFactory)
        {
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _serviceFactory.TestService.GetValues();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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

        [HttpPost]
        public async Task<IActionResult> CreateValue([FromBody] TestBllModel value)
        {
            try
            {
                await _serviceFactory.TestService.CreateValueAsync(value);
                
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
