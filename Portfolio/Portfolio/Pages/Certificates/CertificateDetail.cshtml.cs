using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.Certificates
{
    public class CertificateDetailModel : PageModel
    {
        private readonly ICertificateData _certificateData;

        public Certificate Certificate { get; set; }
        public CertificateDetailModel(ICertificateData certificateData)
        {
            _certificateData = certificateData;
        }
        public void OnGet(int certificateId)
        {
            Certificate = _certificateData.GetCertificateById(certificateId);
        }
    }
}