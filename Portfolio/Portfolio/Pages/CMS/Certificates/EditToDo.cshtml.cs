using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Core;
using Portfolio.Data;
using Portfolio.Utility;

namespace Portfolio.Pages.CMS.Certificates
{
    public class EditToDoModel : CertificateNameModel
    {
        private readonly ICourseData _courseData;
        private readonly ISkillData _skillData;
        private readonly IHtmlHelper _htmlHelper;
        private readonly ICertificateData _certificateData;

        [BindProperty]
        public Course Course { get; set; }

        [BindProperty]
        public Certificate Certificate { get; set; }
        public string Heading { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }

        public EditToDoModel(ICourseData courseData, ISkillData skillData, IHtmlHelper htmlHelper, ICertificateData certificateData)
        {
            _courseData = courseData;
            _skillData = skillData;
            _htmlHelper = htmlHelper;
            _certificateData = certificateData;
        }
        public IActionResult OnGet(int? courseId)
        {
            Categories = _htmlHelper.GetEnumSelectList<CourseCategorie>();
            PopulateSkillsDropDownList(_skillData);
            if (courseId.HasValue)
            {
                Heading = "Edit Course";
                Course = _courseData.GetCourseById(courseId.Value);
            }
            else
            {
                Heading = "Add Course To Follow";
                Course = new Course();

            }
            if(Course == null)
            {
                return RedirectToPage(Constants.NotFound);
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            //To Do - add logic so when a course is completed I add the certificate for it and data is being transferred to Certificates

            PopulateSkillsDropDownList(_skillData);
            if (!ModelState.IsValid)
            {
                Categories = _htmlHelper.GetEnumSelectList<CourseCategorie>();
                return Page();
            }
            if(Course.Id > 0)
            {
                Course = _courseData.UpdateCourse(Course);
            }
            else
            {
                Course = _courseData.AddCourse(Course);
            }

            _courseData.Commit();

            if (!ModelState.IsValid)
            {
                return Page();
            }


            return RedirectToPage("./ToDoList");
        }
    }
}