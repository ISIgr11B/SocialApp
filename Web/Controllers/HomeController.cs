using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bll.Models.PageModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiCaller _apiCaller;

        public HomeController(
            IApiCaller apiCaller
            )
        {
            _apiCaller = apiCaller;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            ViewData["Message"] = "Your application description page.";
            PrivatePageModel privatePage = await _apiCaller.CallApi<PrivatePageModel>("", Helpers.HttpMethodType.GET, "currentuser/GetPrivatePage");            

            return View(privatePage);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
