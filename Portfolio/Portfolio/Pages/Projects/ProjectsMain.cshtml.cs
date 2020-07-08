using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio
{
    public class ProjectsMainModel : PageModel
    {
        private readonly IProjectData _projectData;
        [BindProperty]
        public IEnumerable<PersonalProject> PersonalProjects { get; set; }

        public IEnumerable<PPTag> Tags { get; set; }

        public ProjectsMainModel(IProjectData projectData)
        {
            _projectData = projectData;

        }
        public void OnGet()
        {
            PersonalProjects = _projectData.GetAllPersonalProjects();


        }
    }
}