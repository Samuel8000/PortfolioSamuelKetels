using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Settings.User
{
    [AllowAnonymous]
    public class UserListModel : PageModel
    {
        private readonly IUserData _userData;
        public IEnumerable<Portfolio.Core.User> Users { get; set; }

        public UserListModel(IUserData userData)
        {
            _userData = userData;
        }
        public void OnGet()
        {
            Users = _userData.GetAllUsers();
        }
    }
}