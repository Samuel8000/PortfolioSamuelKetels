using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Core.Modelhelpers;
using Portfolio.Data;

namespace Portfolio.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly IUserData _userData;
        private readonly IPasswordHasher _passwordHasher;

        public string ReturnUrl { get; set; }
        [BindProperty]
        public Login LoginTest { get; set; }

        public Core.User Account { get; set; }


        public LoginModel(IUserData userData, IPasswordHasher passwordHasher)
        {
            _userData = userData;
            _passwordHasher = passwordHasher;
        }

        public IActionResult Login(string returnUrl = ("./Login)"))
        {
            ReturnUrl = LoginTest.ReturnUrl;
            return RedirectToPage(new Login { ReturnUrl = returnUrl });
        }

        public async Task<IActionResult> OnPost()
        {
            var user = _userData.GetUserNameAndPassword(LoginTest.UserName, LoginTest.Password);
            if(user == null)
            {
                return Unauthorized();
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal, new AuthenticationProperties { IsPersistent = LoginTest.RememberLogin });

            return RedirectToPage("./Index");
        }

        
    }
}