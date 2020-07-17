using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{

    public class SqlUserData : IUserData
    {
        private readonly PortfolioDbContext _context;

        public SqlUserData(PortfolioDbContext context)
        {
            _context = context;
        }
        public User GetUserNameAndPassword(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
