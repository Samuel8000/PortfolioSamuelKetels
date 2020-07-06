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
        [Display(Name = "Tag 1")]
        public ProjectTag Tag1 { get; set; }
        [Display(Name = "Tag 2")]
        public ProjectTag Tag2 { get; set; }
        [Display(Name = "Tag 3")]
        public ProjectTag Tag3 { get; set; }
        [Display(Name = "Tag 4")]
        public ProjectTag Tag4 { get; set; }
        [Display(Name = "Tag 5")]
        public ProjectTag Tag5 { get; set; }
    }
}
