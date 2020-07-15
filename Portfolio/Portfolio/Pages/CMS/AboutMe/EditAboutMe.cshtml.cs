using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.AboutMe
{
    public class EditAboutMeModel : PageModel
    {
        private readonly IAboutMeData _aboutMeData;
        [BindProperty]
        public AboutMeInfo AboutMeInfo { get; set; }
        public DateTime TodaysDate
        {
            get
            {
                return DateTime.Now;
            }
        }


        public EditAboutMeModel(IAboutMeData aboutMeData)
        {
            _aboutMeData = aboutMeData;
        }
        public IActionResult OnGet(int? infoId)
        {
            if (infoId.HasValue)
            {
                AboutMeInfo = _aboutMeData.GetAboutMeInfoById(infoId.Value);
            }
            else
            {
                AboutMeInfo = new AboutMeInfo();
            }
            if (AboutMeInfo == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (AboutMeInfo.Id > 0)
            {
                AboutMeInfo.DateUpdated = TodaysDate;
                _aboutMeData.EditInfo(AboutMeInfo);
            }
            else
            {
                _aboutMeData.AddNewInfo(AboutMeInfo);
            }

            _aboutMeData.Commit();

            return RedirectToPage("/CMS/AboutMe/AboutMeList");
        }
    }
}