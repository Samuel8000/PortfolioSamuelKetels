using Portfolio.Core;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Data
{
    public class SqlContactData : IContactData
    {
        private readonly PortfolioDbContext _context;

        

        public SqlContactData(PortfolioDbContext context)
        {
            _context = context;
        }

        public Contact Add(Contact newContact)
        {
            _context.Add(newContact);
            return newContact;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public IEnumerable<Contact> GetAllContactsOrderedByDate()
        {
            return _context.Contacts.OrderByDescending(c => c.DateContacted);
        }

        public Contact GetContactById(int contactId)
        {
            return _context.Contacts.Find(contactId);
        }
    }
}
