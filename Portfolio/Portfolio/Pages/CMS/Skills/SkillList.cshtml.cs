using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Skills
{
    public class SkillListModel : PageModel
    {
        private readonly ISkillData _skillData;
        public IEnumerable<Skill> Skills { get; set; }

        public SkillListModel(ISkillData skillData)
        {
            _skillData = skillData;
        }
        public void OnGet()
        {
            Skills = _skillData.GetAllSkills();
        }
    }
}