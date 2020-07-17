using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.Certificates
{
    [AllowAnonymous]
    public class CertificateDetailModel : PageModel
    {
        private readonly ICertificateData _certificateData;

        public Certificate Certificate { get; set; }
        public CertificateDetailModel(ICertificateData certificateData)
        {
            _certificateData = certificateData;
        }
        public IActionResult OnGet(int certificateId)
        {
            Certificate = _certificateData.GetCertificateById(certificateId);
            if(Certificate == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }
    }
}