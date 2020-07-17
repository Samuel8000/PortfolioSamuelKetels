using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages.CMS.Settings.User
{
    [AllowAnonymous]
    public class UserListModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}