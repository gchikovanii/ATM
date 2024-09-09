using ATM.Models;

namespace ATM.Oprations
{
    public interface ICardService
    {
        List<Card> GetCard(User user);
        Card OrderCard(User user, List<Currencies> currencies);
        bool CloseCard(User user, Card card);
    }
}
