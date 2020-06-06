using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core
{
    public class Contact
    {
        public int Id { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string CompanyName { get; set; }
        public ContactOption ContactOption { get; set; }
        public ContactType ContactType { get; set; }
        public string Remarks { get; set; }
        public DateTime DateContacted { get; set; }

    }
}
