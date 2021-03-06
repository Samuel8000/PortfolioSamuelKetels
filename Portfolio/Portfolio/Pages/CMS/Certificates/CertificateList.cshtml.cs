﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Certificates
{
    [AllowAnonymous]
    public class CertificateListModel : PageModel
    {
        private readonly ICertificateData _certificateData;
        [TempData]
        public string Message { get; set; }
        public IEnumerable<Certificate> Certificates { get; set; }
        public CertificateListModel(ICertificateData certificateData)
        {
            _certificateData = certificateData;
        }
        public void OnGet()
        {
            Certificates = _certificateData.GetAllCertificates();
        }
    }
}