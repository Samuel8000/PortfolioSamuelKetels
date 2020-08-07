using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.Skills
{
    [AllowAnonymous]
    public class SkillDetailModel : PageModel
    {
        private readonly ISkillData _skillData;
        private readonly ICertificateData _certificateData;

        [TempData]
        public string Message { get; set; }
        public Skill Skill { get; set; }
        public string Warning { get; set; }
        public IEnumerable<Certificate> Certificates { get; set; }
        public SkillDetailModel(ISkillData skillData, ICertificateData certificateData)
        {
            _skillData = skillData;
            _certificateData = certificateData;
        }
        public IActionResult OnGet(int skillId)
        {
            Skill = _skillData.GetSkillById(skillId);
            Certificates = _certificateData.GetCertificatesBySkill(skillId);

            if(Skill == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            if(Certificates == null)
            {
                Warning = "No certificates obtained";
            }
            return Page();
        }
    }
}