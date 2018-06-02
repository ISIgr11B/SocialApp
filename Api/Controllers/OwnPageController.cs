using Bll.Models.ContentModels;
using Bll.Models.PageModels;
using Bll.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class OwnPageController : BaseController
    {
        private readonly string  _userLogin;
        public OwnPageController(IServiceFactory serviceFactory) : base(serviceFactory)
        {
            _userLogin = "";
        }
        
        [HttpGet]
        public async Task<IActionResult> GetOwnPage()
        {
            var task = _serviceFactory.PrivatePageService.GetOwnPage(_userLogin);
            var result = await task;
            if (result != null)
                return Ok(result);
            else
                return NoContent();

        }
        [HttpPost]
        public async Task<IActionResult> PostOwnPage([FromBody] PersonModel person)
        {
            var task = _serviceFactory.PrivatePageService.PostOwnPage(_userLogin);
            var result = await task;

            if (result > 0)
                //Updated 
                return Ok();
            else
                //Błąd
                return BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOwnPage([FromBody] PersonModel person)
        {
            var task = _serviceFactory.PrivatePageService.UpdateOwnPage(_userLogin);
            var result = await task;

            if (result > 0)
                //Updated 
                return Ok();
            else
                //Błąd
                return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOwnPage()
        {
            var task = _serviceFactory.PrivatePageService.DeleteOwnPage(_userLogin);
            var result = await task;

            if (result > 0)
                //Deleted 
                return Ok();
            else
                //Błąd
                return BadRequest();
        }
    }
}
