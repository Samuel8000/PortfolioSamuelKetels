using System;
using System.Collections.Generic;
using System.Linq;
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
    public class EditProjectModel : PageModel
    {
        private readonly IProjectData _projectData;
        private readonly IHtmlHelper _htmlHelper;
        private readonly IFileUploader _fileUploader;
        private string uploadPath = Constants.ImageLocation;

        public IFormFile ProjectThumb { get; set; }
        [BindProperty]
        public PersonalProject PersonalProject { get; set; }
        [BindProperty]
        public PPTag PPTag { get; set; }
        public IEnumerable<SelectListItem> ProjectTags { get; set; }
        public string Heading { get; set; }
        public DateTime TodaysDate 
        {
            get 
            {
                return DateTime.Now;
            }                
        }

        public EditProjectModel(IProjectData projectData, IHtmlHelper htmlHelper, IFileUploader fileUploader)
        {
            _projectData = projectData;
            _htmlHelper = htmlHelper;
            _fileUploader = fileUploader;
        }
        public IActionResult OnGet(int? projectId)
        {
            ProjectTags = _htmlHelper.GetEnumSelectList<ProjectTag>();
            if (projectId.HasValue)
            {
                Heading = "Edit";
                PersonalProject = _projectData.GetPersonalProjectById(projectId.Value);
                PPTag = _projectData.GetPPTagsByPersonalProjectId(projectId.Value);
                
            }
            else
            {
                Heading = "Add";
                PersonalProject = new PersonalProject();
                PPTag = new PPTag();
            }
            if(PersonalProject == null)
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
                ProjectTags = _htmlHelper.GetEnumSelectList<ProjectTag>();
                return Page();
            }
            if(PersonalProject.Id > 0)
            {
                _projectData.UpdatePersonalProject(PersonalProject);
                _projectData.Commit();
                PPTag.PersonalProjectId = PersonalProject.Id;
                _projectData.UpdateTags(PPTag);
            }
            else
            {
                _projectData.AddPersonalProject(PersonalProject);
                _projectData.Commit();
                PPTag.PersonalProjectId = PersonalProject.Id;
                _projectData.AddTags(PPTag);

            }

            _projectData.Commit();

            return RedirectToPage("/CMS/Projects/ProjectsList");
        }

        private void UploadThumb()
        {

            if(ProjectThumb != null)
            {
                if(PersonalProject.ProjectThumb != null)
                {
                    _fileUploader.DeleteOldFile(uploadPath, PersonalProject.ProjectThumb);
                    PersonalProject.ProjectThumb = _fileUploader.ProcessUploadedFile(ProjectThumb, uploadPath);
                }

                else if (string.IsNullOrEmpty(PersonalProject.ProjectThumb) || string.IsNullOrWhiteSpace(PersonalProject.ProjectThumb))
                {
                    PersonalProject.ProjectThumb = _fileUploader.ProcessUploadedFile(ProjectThumb, uploadPath);
                }
            }
        }
    }
}