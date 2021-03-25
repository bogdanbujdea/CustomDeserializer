using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CustomDeserializer.Models;

namespace CustomDeserializer.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ImageUploadController: ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] UploadImageModel model)
        {
            Console.WriteLine($"Image {model.ImageName} has a size of: {model.Image.Length} bytes");
            return File(model.Image, "image/jpeg");
        }

    }
}
