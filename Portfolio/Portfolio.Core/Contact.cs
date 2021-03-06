﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name ="I am a(n)...")]
        public ContactType ContactType { get; set; }
        public string Remarks { get; set; }
        public DateTime DateContacted { get; set; }
        public string ContactPhoneNumber { get; set; }
    }
}
