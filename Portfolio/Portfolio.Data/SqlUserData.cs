using Portfolio.Core;
using Portfolio.Core.Modelhelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Portfolio.Data
{

    public class SqlUserData : IUserData
    {
        private readonly PortfolioDbContext _context;
        private readonly IPasswordHasher _passwordHasher;

        public SqlUserData(PortfolioDbContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public User AddUser(User newUser)
        {
            _context.Add(newUser);
            return newUser;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public User GetUserNameAndPassword(string username, string password)
        {

            var user = _context.Users.SingleOrDefault(u => u.Name == username);
            _passwordHasher.Check(user.Password, password);
            return user;
        }

    }
}
