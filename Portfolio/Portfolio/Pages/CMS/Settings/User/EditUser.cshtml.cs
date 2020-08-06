using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Core.Modelhelpers;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Settings.User
{
    [AllowAnonymous]
    public class EditUserModel : PageModel
    {
        private readonly IUserData _userData;
        private readonly IPasswordHasher _passwordHasher;
        [BindProperty]
        public string PassWord { get; set; }

        [BindProperty]
        public Portfolio.Core.User Account { get; set; }

        public EditUserModel(IUserData userData, IPasswordHasher passwordHasher)
        {
            _userData = userData;
            _passwordHasher = passwordHasher;
        }
        public IActionResult OnGet(int? userId)
        {
            if (userId.HasValue)
            {
                Account = _userData.GetUserById(userId.Value);
            }
            else
            {
                Account = new Core.User();
            }
            if(Account == null)
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
            if(Account.Id > 0)
            {
                //Do something
            }
            else
            {
                Account.Password = Hashit();
                Account.Role = "Admin";
                _userData.AddUser(Account);
            }
            _userData.Commit();
            return RedirectToPage("/CMS/Settings/User/UserList");
        }

        private string Hashit()
        {
            var pw = _passwordHasher.Hash(PassWord);
            return pw;
        }
    }
}