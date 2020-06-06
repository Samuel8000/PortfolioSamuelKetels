using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface IContactData
    {
        Contact Add(Contact newContact);
        int Commit();
    }
}
