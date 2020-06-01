using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Utility
{
    public interface IFileUploader
    {
        string ProcessUploadedImage(IFormFile formFile, string path);
    }
}
