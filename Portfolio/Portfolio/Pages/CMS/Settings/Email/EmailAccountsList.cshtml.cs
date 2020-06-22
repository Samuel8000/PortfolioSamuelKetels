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
    public class EmailAccountsListModel : PageModel
    {
        private readonly IEmailSettingsData _emailSettingsData;

        public IEnumerable<EmailSetting> EmailAccounts { get; set; }

        public EmailAccountsListModel(IEmailSettingsData emailSettingsData)
        {
            _emailSettingsData = emailSettingsData;
        }

        public void OnGet()
        {
            EmailAccounts = _emailSettingsData.GetAllEmailAccounts();
        }
    }
}