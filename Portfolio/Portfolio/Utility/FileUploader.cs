﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Portfolio.Utility
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUploader(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public void DeleteOldFile(string path, string fileName)
        {
            string fileLocation = Path.Combine(_webHostEnvironment.WebRootPath, path, fileName);
            File.Delete(fileLocation);
        }

        public string GetRootPath(string path, string fileName)
        {
            string fileLocation = Path.Combine(_webHostEnvironment.WebRootPath, path, fileName);
            return fileLocation;
        }

        public string ProcessUploadedFile(IFormFile formFile, string path)
        {
            string fileName = null;
            if(formFile != null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, path);
                fileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;
                string filePath = Path.Combine(uploadFolder, fileName);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(filestream);
                }
            }
            return fileName;
        }

    }
}
