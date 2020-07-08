using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portfolio.Core
{
    public class PPTag
    {
        public int Id { get; set; }
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
        public int PersonalProjectId { get; set; }
        public PersonalProject PersonalProject { get; set; }
    }
}
