using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio
{
    public class EditCertificateModel : CertificateNameModel
    {
        private readonly ICertificateData _certificateData;
        private readonly ISkillData _skillData;
        [BindProperty]
        public Certificate Certificate { get; set; }

        public EditCertificateModel(ICertificateData certificateData, ISkillData skillData)
        {
            _certificateData = certificateData;
            _skillData = skillData;
        }

        public IActionResult OnGet(int certificateId)
        {

            Certificate = _certificateData.GetCertificateById(certificateId);
            PopulateSkillsDropDownList(_skillData);
            if (Certificate == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }
    }
}