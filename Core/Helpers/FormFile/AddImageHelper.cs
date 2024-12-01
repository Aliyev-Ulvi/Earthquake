using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.FormFile
{
    public class AddImageHelper(IWebHostEnvironment webHostEnvironment) : IAddImageHelper
    {
        private readonly IWebHostEnvironment _webHostEnvironment = webHostEnvironment;

        public void AddImage(IFormFile formFile, string guid)
        {
            var fileName = guid;
            var wwwFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            var imageFolder = Path.Combine(wwwFolder, fileName);

            using var fileStream = new FileStream(imageFolder, FileMode.Create);
            formFile.CopyTo(fileStream);
        }
    }
}
