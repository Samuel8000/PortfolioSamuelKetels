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
        [BindProperty]
        public Skill Skill { get; set; }
        public IEnumerable<SelectListItem> SkillLevels { get; set; }
        public EditSkillModel(ISkillData skillData, IHtmlHelper htmlHelper)
        {
            _skillData = skillData;
            _htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? skillId)
        {
            SkillLevels = _htmlHelper.GetEnumSelectList<SkillLevel>();
            if (skillId.HasValue)
            {
                Skill = _skillData.GetSkillById(skillId.Value);
            }
            else
            {
                Skill = new Skill();
            }
            if(Skill == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                SkillLevels = _htmlHelper.GetEnumSelectList<SkillLevel>();
                return Page();
            }
            if(Skill.Id > 0)
            {
                _skillData.UpdateSkill(Skill);
            }
            else
            {
                _skillData.Add(Skill);
            }

            _skillData.Commit();
            TempData["Message"] = $"{Skill.SkillName} Saved";

            return RedirectToPage("/Skills/SkillDetail", new { skillId = Skill.Id });
        }
    }
}