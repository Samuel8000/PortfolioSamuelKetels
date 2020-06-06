using Portfolio.Core;

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
    }
}
