using ATM.Models;

namespace ATM.Operations
{
    public interface IOperations
    {
        string MakeDeposit(Currencies currencies,decimal money, User user, Card card);
        string Withdraw(Currencies currencies,decimal money, User user, Card card);

    }
}
