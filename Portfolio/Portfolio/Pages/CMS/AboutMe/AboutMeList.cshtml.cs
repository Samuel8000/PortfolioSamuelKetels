using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;
using Portfolio.Core;

namespace Portfolio.Pages.CMS.AboutMe
{
    public class AboutMeListModel : PageModel
    {
        private readonly IAboutMeData _aboutMeData;
        public IEnumerable<AboutMeInfo> AboutMeList { get; set; }

        public AboutMeListModel(IAboutMeData aboutMeData)
        {
           _aboutMeData = aboutMeData;
        }
        public void OnGet()
        {
            AboutMeList = _aboutMeData.GetAllEntries();
        }
    }
}