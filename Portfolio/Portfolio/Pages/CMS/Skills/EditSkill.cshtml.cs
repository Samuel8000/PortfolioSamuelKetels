using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Skills
{
    public class EditSkillModel : PageModel
    {
        private readonly ISkillData _skillData;
        private readonly IHtmlHelper _htmlHelper;

        public Skill Skill { get; set; }
        public IEnumerable<SelectListItem> SkillLevels { get; set; }
        public EditSkillModel(ISkillData skillData, IHtmlHelper htmlHelper)
        {
            _skillData = skillData;
            _htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int skillId)
        {
            SkillLevels = _htmlHelper.GetEnumSelectList<SkillLevel>();
            Skill = _skillData.GetSkillById(skillId);
            if(Skill == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }
    }
}