using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio
{
    public class AboutMeModel : PageModel
    {
        private readonly IAboutMeData _aboutMeData;
        [BindProperty]
        public AboutMeInfo AboutMeInfo { get; set; }

        public AboutMeModel(IAboutMeData aboutMeData)
        {
            _aboutMeData = aboutMeData;
        }
        public void OnGet()
        {
            AboutMeInfo = _aboutMeData.GetAboutMeInfoLive();
        }
    }
}