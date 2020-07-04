using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectThumb { get; set; }
        public DateTime DateCompleted { get; set; }
        public ProjectTag Tag1 { get; set; }
        public ProjectTag Tag2 { get; set; }
        public ProjectTag Tag3 { get; set; }
        public ProjectTag Tag4 { get; set; }
        public ProjectTag Tag5 { get; set; }
    }
}
