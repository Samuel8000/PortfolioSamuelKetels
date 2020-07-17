using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio
{
    [AllowAnonymous]
    public class SkillsMainModel : PageModel
    {
        private readonly ISkillData _skillData;

        public IEnumerable<Skill> Skills { get; set; }

        public SkillsMainModel(ISkillData skillData)
        {
            _skillData = skillData;
        }
        public void OnGet()
        {
            Skills = _skillData.GetAllSkills();
        }

    }
}