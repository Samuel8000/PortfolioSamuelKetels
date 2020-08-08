using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portfolio.Core
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public CourseCategorie CourseCategories { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public bool Done { get; set; }
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Text)]
        public DateTime DateCompleted { get; set; }
    }
}
