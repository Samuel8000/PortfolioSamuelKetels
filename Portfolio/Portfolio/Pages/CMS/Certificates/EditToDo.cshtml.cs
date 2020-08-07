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

        [BindProperty]
        public Course Course { get; set; }
        public string Heading { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }

        public EditToDoModel(ICourseData courseData, ISkillData skillData, IHtmlHelper htmlHelper)
        {
            _courseData = courseData;
            _skillData = skillData;
            _htmlHelper = htmlHelper;
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
            return RedirectToPage("./ToDoList");
        }
    }
}