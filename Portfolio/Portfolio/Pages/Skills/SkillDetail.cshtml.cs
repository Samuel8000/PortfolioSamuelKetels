using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.Skills
{
    public class SkillDetailModel : PageModel
    {
        private readonly ISkillData _skillData;

        public Skill Skill { get; set; }
        public SkillDetailModel(ISkillData skillData)
        {
            _skillData = skillData;
        }
        public void OnGet(int skillId)
        {
            Skill = _skillData.GetSkillById(skillId);
        }
    }
}