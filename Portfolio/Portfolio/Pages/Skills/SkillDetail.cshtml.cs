using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;

namespace Portfolio.Pages.Skills
{
    public class SkillDetailModel : PageModel
    {
        public Skill Skill { get; set; }
        public void OnGet(int skillId)
        {
            Skill = new Skill();
            Skill.Id = skillId;
        }
    }
}