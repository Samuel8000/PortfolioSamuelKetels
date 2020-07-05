using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Projects
{
    public class ProjectsListModel : PageModel
    {
        private readonly IProjectData _projectData;

        public IEnumerable<PersonalProject> PersonalProjects { get; set; }
        public IEnumerable<FreeCodeCampProject> FccRWDProjects { get; set; }

        public ProjectsListModel(IProjectData projectData)
        {
            _projectData = projectData;
        }
        public void OnGet()
        {
            PersonalProjects = _projectData.GetAllPersonalProjects();
            FccRWDProjects = _projectData.GetFreeCodeCampRWDProjects();
                
        }
    }
}