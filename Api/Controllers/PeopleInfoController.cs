using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helpers.Models.ContentModels;
using Bll.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class PeopleInfoController : BaseController
    {
        public PeopleInfoController(IServiceFactory serviceFactory) : base(serviceFactory)
        {
        }

        
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string userLogin)
        {
            var person = _serviceFactory.PersonInfoService.GetPerson(userLogin);

            if (person != null)
            {
                return Ok(person);
            }
            else
                return BadRequest();
        }
        
    }
}
