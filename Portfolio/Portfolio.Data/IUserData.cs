using Portfolio.Core;

namespace Portfolio.Data
{
    public interface IUserData
    {
        User GetUserNameAndPassword(string username, string password);
    }
}
