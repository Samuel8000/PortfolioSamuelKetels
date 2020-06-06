using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Core;

namespace Portfolio
{
    public class ContactModel : PageModel
    {
        private readonly IHtmlHelper _htmlHelper;

        public IEnumerable<SelectListItem> ContactTypes { get; set; }
        public IEnumerable<SelectListItem> ContactOptions { get; set; }
        public Contact Contact { get; set; }

        public ContactModel(IHtmlHelper htmlHelper)
        {
            _htmlHelper = htmlHelper;
        }
        public void OnGet()
        {
            ContactTypes = _htmlHelper.GetEnumSelectList<ContactType>();
            ContactOptions = _htmlHelper.GetEnumSelectList<ContactOption>();
        }
    }
}