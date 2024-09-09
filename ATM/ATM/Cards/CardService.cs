using ATM.Account;
using ATM.ExceptionsAggregate;
using ATM.Models;

namespace ATM.Oprations
{
    public class CardService : ICardService
    {
        private readonly IAccountService _accountService;
        public CardService(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public List<Card> GetCard(User user)
        {
            return user.Cards.ToList();
        }
        public Card OrderCard(User user, List<Currencies> currencies)
        {
            Random random = new();
            Card card = new Card
            {
                CardNumber = Guid.NewGuid(),
                Currencies = currencies,
                CVC = random.Next(100, 999),
                Exp = DateTimeOffset.UtcNow.AddYears(4)
            };
            var currentUser = _accountService.GetUser(user);
            if (currentUser == null)
                throw new UserNotFoundException("User not found.");
            currentUser.Cards.Add(card);
            return card;

        }
        public bool CloseCard(User user, Card card)
        {
            var currentUser = _accountService.GetUser(user);
            if(currentUser == null)
                throw new UserNotFoundException("User not found.");
            currentUser.Cards.Remove(card);
            return true;
        }
    }
}
