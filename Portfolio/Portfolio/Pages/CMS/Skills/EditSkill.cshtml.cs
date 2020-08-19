using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Core;
using Portfolio.Data;
using Portfolio.Utility;

namespace Portfolio.Pages.CMS.Skills
{
    public class EditSkillModel : PageModel
    {
        private readonly ISkillData _skillData;
        private readonly IHtmlHelper _htmlHelper;
        private readonly IFileUploader _fileUploader;
        private readonly ISkillPathData _skillPathData;
        private string uploadPath  = Constants.ImageLocation;
        public IFormFile Logo { get; set; }
        public IFormFile Chart { get; set; }
        [BindProperty]
        public Skill Skill { get; set; }
        [BindProperty]
        public SkillPath SkillPath { get; set; }
        public IEnumerable<SelectListItem> SkillLevels { get; set; }
        public string Heading { get; set; }
        public EditSkillModel(ISkillData skillData, IHtmlHelper htmlHelper, IFileUploader fileUploader, ISkillPathData skillPathData)
        {
            _skillData = skillData;
            _htmlHelper = htmlHelper;
            _fileUploader = fileUploader;
            _skillPathData = skillPathData;
        }
        public IActionResult OnGet(int? skillId)
        {
            SkillLevels = _htmlHelper.GetEnumSelectList<SkillLevel>();
            if (skillId.HasValue)
            {
                Heading = "Edit ";
                Skill = _skillData.GetSkillById(skillId.Value);
                SkillPath = new SkillPath();
            }
            else
            {
                Heading = "Add New Skill";
                Skill = new Skill();
                SkillPath = new SkillPath();
            }
            if(Skill == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            UploadLogo();
            UploadChart();

            if (!ModelState.IsValid)
            {
                SkillLevels = _htmlHelper.GetEnumSelectList<SkillLevel>();
                return Page();
            }
            if(Skill.Id > 0)
            {
                _skillData.UpdateSkill(Skill);
                _skillData.Commit();
                OnPostSkillPath();
            }
            else
            {
                _skillData.Add(Skill);
            }

            _skillData.Commit();
            _skillPathData.CommitSP();
            TempData["Message"] = $"{Skill.SkillName} Saved";

            return RedirectToPage("/Skills/SkillDetail", new { skillId = Skill.Id });
        }

        public IActionResult OnGetPartial() => Partial("_SkillPathPartial");

        public void OnPostSkillPath()
        {
            SkillPath.Id += 1;
            _skillPathData.AddNewSkillPath(SkillPath);
            _skillPathData.CommitSP();

        }

        private void UploadLogo()
        {

            if (Logo != null)
            {
                if (Skill.LogoFilePath != null)
                {
                    _fileUploader.DeleteOldFile(uploadPath, Skill.LogoFilePath);
                    Skill.LogoFilePath =_fileUploader.ProcessUploadedFile(Logo, uploadPath);
                }
                else if (string.IsNullOrEmpty(Skill.LogoFilePath) || string.IsNullOrWhiteSpace(Skill.LogoFilePath))
                {
                    Skill.LogoFilePath = _fileUploader.ProcessUploadedFile(Logo, uploadPath);
                }
            }
        }
        private void UploadChart()
        {

            if (Chart != null)
            {
                if (Skill.PsChartFilePath != null)
                {
                    _fileUploader.DeleteOldFile(uploadPath, Skill.PsChartFilePath);
                    Skill.PsChartFilePath = _fileUploader.ProcessUploadedFile(Chart, uploadPath);
                }
                else if (string.IsNullOrEmpty(Skill.PsChartFilePath) || string.IsNullOrWhiteSpace(Skill.PsChartFilePath))
                {
                    Skill.PsChartFilePath = _fileUploader.ProcessUploadedFile(Chart, uploadPath);
                }
            }
        }
    }
}