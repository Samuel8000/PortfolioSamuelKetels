using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Core.Modelhelpers;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Settings.Email
{
    public class EmailSetupModel : PageModel
    {
        private readonly IEmailSettingsData _emailSettingsData;
        private readonly IPasswordHasher _passwordHasher;

        [BindProperty]
        public EmailSetting EmailSettings { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public EmailSetupModel(IEmailSettingsData emailSettingsData, IPasswordHasher passwordHasher)
        {
            _emailSettingsData = emailSettingsData;
            _passwordHasher = passwordHasher;
        }
        public IActionResult OnGet(int? emailSettingsId)
        {
            if (emailSettingsId.HasValue)
            {
                EmailSettings = _emailSettingsData.GetEmailSettingById(emailSettingsId.Value);
            }
            else
            {
                EmailSettings = new EmailSetting();
            }
            if (EmailSettings == null)
            {
                return RedirectToPage("/Shared/_NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            EmailSettings.Password = _passwordHasher.Hash(Password);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(EmailSettings.Id > 0)
            {

                _emailSettingsData.UpdateEmailSetting(EmailSettings);
            }
           
            else
            {
                _emailSettingsData.NewEmailSetting(EmailSettings);
            }
            _emailSettingsData.Commit();

            return Page();
        }



    }
}