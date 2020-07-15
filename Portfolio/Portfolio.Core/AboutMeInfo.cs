using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core
{
    public class AboutMeInfo
    {
        public int Id { get; set; }
        public string PersonalInfo { get; set; }
        public string DevelopmentInfo { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Live { get; set; }
    }
}
