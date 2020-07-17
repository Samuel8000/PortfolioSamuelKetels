using Portfolio.Core;
using System.Collections;
using System.Collections.Generic;

namespace Portfolio.Data
{
    public interface IUserData
    {
        User GetUserNameAndPassword(string username, string password);
        IEnumerable<User> GetAllUsers();

        User GetUserById(int userId);

        User AddUser(User newUser);

        int Commit();
    }
}
