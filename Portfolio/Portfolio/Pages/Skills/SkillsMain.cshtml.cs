using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio
{
    public class SkillsMainModel : PageModel
    {
        private readonly ISkillData _skillData;
        private readonly ICertificateData _certificateData;

        public IEnumerable<Skill> Skills { get; set; }

        [BindProperty]
        public IEnumerable<Certificate> Certificates { get; set; }

        public SkillsMainModel(ISkillData skillData,ICertificateData certificateData)
        {
            _skillData = skillData;
            _certificateData = certificateData;
        }
        public void OnGet()
        {
            Skills = _skillData.GetAllSkills();

        }

        public IActionResult OnGetCertificates(int skillId)
        {
            Certificates = _certificateData.GetCertificatesBySkill(skillId);
            return RedirectToPage("/Skills/SkillDetail", new { skillId = Certificates.Where(c => c.SkillId == skillId )});

        }
    }
}