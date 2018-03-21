using Bll.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IServiceFactory _serviceFactory;

        public BaseController(
            IServiceFactory serviceFactory
            )
        {
            _serviceFactory = serviceFactory;
        }
    }
}
