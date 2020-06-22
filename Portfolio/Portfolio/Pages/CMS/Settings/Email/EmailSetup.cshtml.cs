using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Settings.Email
{
    public class EmailSetupModel : PageModel
    {
        private readonly IEmailSettingsData _emailSettingsData;

        public EmailSetting EmailSetting { get; set; }

        public EmailSetupModel(IEmailSettingsData emailSettingsData)
        {
            _emailSettingsData = emailSettingsData;
        }
        public IActionResult OnGet(int? emailSettingsId)
        {
            if (emailSettingsId.HasValue)
            {
                EmailSetting = _emailSettingsData.GetEmailSettingById(emailSettingsId.Value);
            }
            else
            {
                EmailSetting = new EmailSetting();
            }
            if (EmailSetting == null)
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
            if(EmailSetting.Id > 0)
            {
                _emailSettingsData.UpdateEmailSetting(EmailSetting);
            }
            else
            {
                _emailSettingsData.NewEmailSetting(EmailSetting);
            }
            _emailSettingsData.Commit();

            return RedirectToPage("/Email/EmailAccountsList");
        }
    }
}