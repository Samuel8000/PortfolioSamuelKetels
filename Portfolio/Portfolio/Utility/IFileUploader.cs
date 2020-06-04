using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Utility
{
    public interface IFileUploader
    {
        string ProcessUploadedFile(IFormFile formFile, string path);
        void DeleteOldFile(string path, string fileName);
        string GetRootPath(string path, string fileName);
    }
}
