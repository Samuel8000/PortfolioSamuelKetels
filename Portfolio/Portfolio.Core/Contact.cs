using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core
{
    public class Contact
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string CompanyName { get; set; }
        public ContactOptions ContactOptions { get; set; }
        public string Remarks { get; set; }

    }
}
