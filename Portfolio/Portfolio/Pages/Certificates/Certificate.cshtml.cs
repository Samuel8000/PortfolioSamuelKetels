using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;
using Portfolio.Utility;

namespace Portfolio.Pages.Certificates
{
    public class CertificateModel : PageModel
    {
        private readonly ICertificateData _certificateData;
        private readonly IFileUploader _fileUploader;
        private string uploadPath = Constants.CertificateLocation;

        public CertificateModel(ICertificateData certificateData, IFileUploader fileUploader)
        {
            _certificateData = certificateData;
            _fileUploader = fileUploader;
        }
        public Certificate Certificate { get; set; }

        public IActionResult OnGet(int certificateId)
        {
            Certificate = _certificateData.GetCertificateById(certificateId);
            var stream = new FileStream(_fileUploader.GetRootPath(uploadPath, Certificate.CertificateFileName), FileMode.Open);
            return new FileStreamResult(stream, "application/pdf");
        }
    }
}