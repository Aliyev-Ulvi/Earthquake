using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.FormFile
{
    public interface IAddImageHelper
    {
        void AddImage(IFormFile formFile, string guid);
    }
}
// NuGet\Install-Package Microsoft.EntityFrameworkCore -Version 8.0.8