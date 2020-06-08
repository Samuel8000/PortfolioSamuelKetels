using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface IContactData
    {
        Contact GetContactById(int contactId);
        IEnumerable<Contact> GetAllContactsOrderedByDate();   
        Contact Add(Contact newContact);
        int Commit();
    }
}
