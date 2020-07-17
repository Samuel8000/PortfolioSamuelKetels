using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Core;
using Portfolio.Core.Modelhelpers;
using Portfolio.Data;
using Portfolio.Utility;

namespace Portfolio
{
    [AllowAnonymous]
    public class ContactModel : PageModel
    {
        private readonly IHtmlHelper _htmlHelper;
        private readonly IContactData _contactData;

        public IEnumerable<SelectListItem> ContactTypes { get; set; }
        public IEnumerable<SelectListItem> ContactOptions { get; set; }
        [BindProperty]
        public Contact Contact { get; set; }
        public DateTime TodaysDate
        {
            get
            {
                return DateTime.Now;
            }
        }

        public ContactModel(IHtmlHelper htmlHelper, IContactData contactData)
        {
            _htmlHelper = htmlHelper;
            _contactData = contactData;
        }
        public void OnGet()
        {
            LoadEnums();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                LoadEnums();
                return Page();
            }

            Contact.DateContacted = TodaysDate;
            _contactData.Add(Contact);
            _contactData.Commit();
            LoadEnums();

            return Page();        
        }

        private void LoadEnums()
        {
            ContactTypes = _htmlHelper.GetEnumSelectList<ContactType>();
            ContactOptions = _htmlHelper.GetEnumSelectList<ContactOption>();
        }

    }
}