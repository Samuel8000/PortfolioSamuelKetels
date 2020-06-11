using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core
{
    public class ReplyContact : Contact
    {
        public bool ContactReplied { get; set; }
        public DateTime DateReplied { get; set; }
    }
}
