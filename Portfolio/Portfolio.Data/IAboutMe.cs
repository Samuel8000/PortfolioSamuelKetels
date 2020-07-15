using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface IAboutMe
    {
        IEnumerable<AboutMe> GetAllEntries();
    }

    public class SqlAboutMe : IAboutMe
    {
        private readonly PortfolioDbContext _context;

        public SqlAboutMe(PortfolioDbContext context)
        {
            _context = context;
        }
        public IEnumerable<AboutMe> GetAllEntries()
        {
            throw new NotImplementedException();
        }
    }
}
