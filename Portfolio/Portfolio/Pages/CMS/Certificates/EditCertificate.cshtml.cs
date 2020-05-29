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

        public IActionResult OnGet(int? certificateId)
        {
            PopulateSkillsDropDownList(_skillData);
            if (certificateId.HasValue)
            {
                Certificate = _certificateData.GetCertificateById(certificateId.Value);
            }
            else
            {
                Certificate = new Certificate();
            }

            if (Certificate == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                PopulateSkillsDropDownList(_skillData);
                return Page();
            }
            if(Certificate.Id > 0)
            {
                _certificateData.Update(Certificate);
            }
            else
            {
                _certificateData.Add(Certificate);
            }
            _certificateData.Commit();
            TempData["Message"] = $"{Certificate.CertificateName} Saved";
            return RedirectToPage("./CertificateList");
        }
    }
}