using ATM.Account;
using ATM.ExceptionsAggregate;
using ATM.Models;

namespace ATM.Operations
{
    public class Operations : IOperations
    {
        private readonly IAccountService _accountService;

        public Operations(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public string MakeDeposit(Currencies currencies, decimal money, User user, Card card)
        {
            var currentUser = _accountService.GetUser(user);
            if(currentUser == null)
                throw new UserNotFoundException("User not found.");

            var curretCard = currentUser.Cards.Any(i => i.CardNumber == card.CardNumber);
            if(curretCard == false)
                return "Error while making deposit, please try again later";
            card.Total += money;
            return $"You made deposit on card: {card.CardNumber} - {money} and your balance is {card.Total}";
        }

        public string Withdraw(Currencies currencies, decimal money, User user, Card card)
        {
            var currentUser = _accountService.GetUser(user);
            if (currentUser == null)
                throw new UserNotFoundException("User not found.");

            var curretCard = currentUser.Cards.Any(i => i.CardNumber == card.CardNumber);
            if (curretCard == false)
                return "Error while making deposit, please try again later";
            if (card.Total < money)
                return $"You can't withdraw money, you have on balance: {card.Total} and tried to withdraw {money}";
            card.Total -= money;
            return $"You made deposit on card: {card.CardNumber} - {money} and your balance is {card.Total}";
        }
    }
}
