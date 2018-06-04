using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/PhotoGallery")]
    public class GalleryController : BaseController
    {
        public GalleryController(IServiceFactory serviceFactory) : base(serviceFactory)
        {
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGallery(string authLogin, string galleryOwner)
        {
            return Ok();
        }
        [HttpGet("{id}/Length")]
        public async Task<IActionResult> GetLength(string authLogin, string galleryOwner)
        {
            return Ok();
        }

        [HttpGet("{id}/Preview")]
        public async Task<IActionResult> GetPreview(string authLogin, string galleryOwner)
        {
            return Ok();
        }
    }
}