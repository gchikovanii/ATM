using ATM.Models;

namespace ATM.Account
{
    public class AccountService : IAccountService
    {
        public List<User> accounts = new();
        public bool CloseAccount(User user)
        {
            if (UserAlreadyExists(user))
                return false;
            accounts.Remove(user);
            return true;
        }
        public bool CreateAccount(User user)
        {
            if(UserAlreadyExists(user))
                return false;
            accounts.Add(user);
            return true;
        }

        public User GetUser(User user)
        {
            return accounts.FirstOrDefault(user);
        }

        private bool UserAlreadyExists(User user)
        {
            return accounts.Any(i => i.Identifier == user.Identifier);  
        }
    }
}
