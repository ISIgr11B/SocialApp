using Bll.Models.PageModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Services;

namespace Web.Controllers
{
    public class PrivatePageController : Controller
    {
        private readonly IApiCaller _apiCaller;

        public PrivatePageController(
            IApiCaller apiCaller
            )
        {
            _apiCaller = apiCaller;
        }

        public async Task<IActionResult> ProfilePage()
        {
            var privatePage = await _apiCaller.CallApi<PrivatePageModel>("", Helpers.HttpMethodType.GET, "currentuser/GetOwnPage");

            return View(privatePage);
        }
    }
}