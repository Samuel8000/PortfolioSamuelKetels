using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Certificates
{
    [AllowAnonymous]
    public class ToDoListModel : PageModel
    {
        private readonly ICourseData _courseData;

        public IEnumerable<Course> CoursesDone { get; set; }
        public IEnumerable<Course> CoursesToDo { get; set; }
        public ToDoListModel(ICourseData courseData)
        {
            _courseData = courseData;
        }
        public IActionResult OnGet()
        {
            CoursesDone = _courseData.GetAllCoursesDone();
            CoursesToDo = _courseData.GetAllCoursesToDo();
            return Page();
        }
    }
}