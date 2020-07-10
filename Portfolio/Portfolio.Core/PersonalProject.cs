using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portfolio.Core
{
    public class PersonalProject
    {
        public int Id { get; set; }
        [Display(Name ="Project Name")]
        [Required]
        public string ProjectName { get; set; }
        [Display(Name = "Project Description")]
        public string ProjectDescription { get; set; }
        [Display(Name = "Image Preview")]
        public string ProjectThumb { get; set; }
        [Display(Name = "Date Completed")]
        public DateTime DateCompleted { get; set; }
        [Display(Name = "GitHub URL")]
        public string CodeLink { get; set; }

    }
}
