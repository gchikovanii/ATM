using ATM.Models;

namespace ATM.Account
{
    public interface IAccountService
    {
        User GetUser(User user);
        bool CreateAccount(User user);
        bool CloseAccount(User user);
    }
}
