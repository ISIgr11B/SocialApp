using Bll.Services;
using Helpers.Models.ContentModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class OwnPageController : BaseController
    {
        
        public OwnPageController(IServiceFactory serviceFactory) : base(serviceFactory)
        {
        }
        
        [HttpGet]
        public async Task<IActionResult> GetOwnPage(string userLogin)
        {

            var result = _serviceFactory.PrivatePageService.GetOwnPage(userLogin);
            if (result != null)
                return Ok(result);
            else
                return NoContent();

        }
    }
}
