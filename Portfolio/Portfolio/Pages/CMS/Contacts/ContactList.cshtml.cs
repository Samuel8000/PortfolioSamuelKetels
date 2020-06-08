using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.CMS.Contacts
{
    public class ContactListModel : PageModel
    {
        private readonly IContactData _contactData;
        public IEnumerable<Contact> Contacts { get; set; }
        [BindProperty]
        public Contact Contact { get; set; }
        public ContactListModel(IContactData contactData)
        {
            _contactData = contactData;
        }
        public void OnGet()
        {
            Contacts = _contactData.GetAllContactsOrderedByDate();
        }

        public IActionResult OnGetContact(int contactId)
        {
            Contact = _contactData.GetContactById(contactId);
            return Page();
        }
    }
}