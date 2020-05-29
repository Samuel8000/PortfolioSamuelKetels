using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Data;

namespace Portfolio
{
    public class CertificateNameModel : PageModel
    {
        public SelectList SkillsSelectList { get; set; }

        public void PopulateSkillsDropDownList(ISkillData _skillData, object selectedSkill = null)
        {
            var skillslist = _skillData.GetAllSkills();
            SkillsSelectList = new SelectList(skillslist, "Id", "SkillName", selectedSkill);
        }
    }
}