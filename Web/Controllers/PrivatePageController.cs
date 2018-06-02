using Helpers.Models.PageModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Web.Services;

namespace Web.Controllers
{
    public class PrivatePageController : Controller
    {
        private readonly IApiCaller _apiCaller;
        private readonly IHostingEnvironment _environment;

        public PrivatePageController(
            IApiCaller apiCaller,
            IHostingEnvironment environment
            )
        {
            _apiCaller = apiCaller;
            _environment = environment;
        }

        [HttpGet]
        public async Task<IActionResult> ProfilePage()
        {
            var privatePage = await _apiCaller.CallApi<PrivatePageModel>("", Helpers.HttpMethodType.GET, "OwnPage");

            return View(privatePage);
        }
        [HttpPost]
        public async Task<IActionResult> Upload(ICollection<IFormFile> files)
        {
            var uploads = Path.Combine(_environment.WebRootPath, "uploads");
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
            }
            return RedirectToAction("ProfilePage");
        }
    }
}