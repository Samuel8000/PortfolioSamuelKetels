﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Settings.Email
{
    public class EmailSetupModel : PageModel
    {
        private readonly IEmailSettingsData _emailSettingsData;

        public EmailSetupModel(IEmailSettingsData emailSettingsData)
        {
            _emailSettingsData = emailSettingsData;
        }
        public void OnGet()
        {

        }
    }
}