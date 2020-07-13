using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core
{
    public class FreeCodeCampProject
    {
        public int Id { get; set; }
        public string FccProjectName { get; set; }
        public string FccProjectDescription { get; set; }
        public string FccProjectLink { get; set; }
        public string FccProjectThumb { get; set; }
        public FccCategory FccCategory { get; set; }
    }

}
