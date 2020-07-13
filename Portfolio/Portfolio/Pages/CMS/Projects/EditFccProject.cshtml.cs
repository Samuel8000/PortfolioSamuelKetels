using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Core;
using Portfolio.Data;
using Portfolio.Utility;

namespace Portfolio.Pages.CMS.Projects
{
    public class EditFccProjectModel : PageModel
    {
        private readonly IProjectData _projectData;
        private readonly IFileUploader _fileUploader;
        private readonly IHtmlHelper _htmlHelper;
        private string uploadPath = Constants.ImageLocation;
        [BindProperty]
        public FreeCodeCampProject FreeCodeCampProject { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public string Heading { get; set; }
        public IFormFile ProjectThumb { get; set; }

        public EditFccProjectModel(IProjectData projectData, IFileUploader fileUploader, IHtmlHelper htmlHelper)
        {
            _projectData = projectData;
            _fileUploader = fileUploader;
            _htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? fccProjectId)
        {
            Categories = _htmlHelper.GetEnumSelectList<FccCategory>();
            if (fccProjectId.HasValue)
            {
                Heading = "Edit";
                FreeCodeCampProject = _projectData.GetFreeCodeCampProjectById(fccProjectId.Value);
            }
            else
            {
                Heading = "Add";
                FreeCodeCampProject = new FreeCodeCampProject();
            }
            if(FreeCodeCampProject == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            UploadThumb();

            if (!ModelState.IsValid)
            {
                Categories = _htmlHelper.GetEnumSelectList<FccCategory>();
                return Page();
            }
            if(FreeCodeCampProject.Id > 0)
            {
                _projectData.UpdateFccProject(FreeCodeCampProject);
            }
            else
            {
                _projectData.AddFccProject(FreeCodeCampProject);
            }

            _projectData.Commit();

            return RedirectToPage("/CMS/Projects/ProjectsList");

        }

        private void UploadThumb()
        {
            if(ProjectThumb != null)
            {
                if(FreeCodeCampProject.FccProjectThumb != null)
                {
                    _fileUploader.DeleteOldFile(uploadPath, FreeCodeCampProject.FccProjectThumb);
                    FreeCodeCampProject.FccProjectThumb = _fileUploader.ProcessUploadedFile(ProjectThumb, uploadPath);
                }
                else if(string.IsNullOrEmpty(FreeCodeCampProject.FccProjectThumb) || string.IsNullOrWhiteSpace(FreeCodeCampProject.FccProjectThumb))
                {
                    FreeCodeCampProject.FccProjectThumb = _fileUploader.ProcessUploadedFile(ProjectThumb, uploadPath);
                }
            }
        }
    }
}