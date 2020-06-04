﻿using System.Collections.Generic;
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
        private string uploadPath  = Constants.ImageLocation;
        public IFormFile Logo { get; set; }
        public IFormFile Chart { get; set; }
        [BindProperty]
        public Skill Skill { get; set; }
        public IEnumerable<SelectListItem> SkillLevels { get; set; }
        public string Heading { get; set; }
        public EditSkillModel(ISkillData skillData, IHtmlHelper htmlHelper, IFileUploader fileUploader)
        {
            _skillData = skillData;
            _htmlHelper = htmlHelper;
            _fileUploader = fileUploader;
        }
        public IActionResult OnGet(int? skillId)
        {
            SkillLevels = _htmlHelper.GetEnumSelectList<SkillLevel>();
            if (skillId.HasValue)
            {
                Heading = "Edit ";
                Skill = _skillData.GetSkillById(skillId.Value);
            }
            else
            {
                Heading = "Add New Skill";
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
            }
            else
            {
                _skillData.Add(Skill);
            }

            _skillData.Commit();
            TempData["Message"] = $"{Skill.SkillName} Saved";

            return RedirectToPage("/Skills/SkillDetail", new { skillId = Skill.Id });
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