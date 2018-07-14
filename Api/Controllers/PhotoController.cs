using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Helpers.Models.DataModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{

    [Route("api/[controller]")]
    public class PhotoController : Controller
    {
        private readonly IHostingEnvironment _environment;

        public PhotoController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

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
        [HttpPost]
        public async Task<IActionResult> Upload(ICollection<IFormFile> files)
        {
            var uploads = Path.Combine(_environment.WebRootPath, "uploads");
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    try
                    {
                        using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Directory.CreateDirectory(uploads);
                    }
                }
            }
            return Ok();
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
