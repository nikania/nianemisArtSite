using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nianemisArtSite.Services;

namespace nianemisArtSite.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ImgController : ControllerBase
    {
        private readonly IImagesService _imageService;

        public ImgController(IImagesService imageService)
        {
            _imageService = imageService;
        }
        // GET: /Img
        [HttpGet("{dir}")]
        public Task<IEnumerable<string>> Get(string dir)
        {           
            return _imageService.GetImageListAsync(dir);
        }

        // GET: /Img/5
        [HttpGet("{dir}/{name}")]
        public async Task<IActionResult> GetImage(string dir, string name)
        {
            var array = await _imageService.GetImageAsync(dir, name);
            return File(array, "image/jpeg");

        }

        [HttpGet("{dir}/{name}/{number}")]
        public async Task<IActionResult> GetImagePreview(string dir, string name, int number)
        {
            var array = await _imageService.GetImagePreviewAsync(dir, name, number);
            return File(array, "image/jpeg");

        }
    }
}
