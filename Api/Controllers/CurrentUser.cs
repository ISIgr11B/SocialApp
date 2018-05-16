using Bll.Models.ContentModels;
using Bll.Models.PageModels;
using Bll.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    public class CurrentUser : BaseController
    {
        public CurrentUser(IServiceFactory serviceFactory) : base(serviceFactory)
        {
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("dasdasdas");
        }

        [HttpGet]
        public PrivatePageModel GetOwnPage()
        {            
            return _serviceFactory.PrivatePageService.GetOwnPage();
        }
        [HttpPost]
        public IActionResult PostPicture([FromBody] object Picture)
        {
            //WebImage photo = 

            return Ok();
        }
       
    }
}
