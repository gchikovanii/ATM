using System.ComponentModel.DataAnnotations;

namespace ATM.Models
{
    public class Card
    {
        public User User { get; private set; }
        public Guid CardNumber { get; set; }
        [Range(100, 999, ErrorMessage = "CVC must be a 3-digit number.")]
        public int CVC { get; set; }
        public DateTimeOffset Exp { get; set; }
        public List<Currencies> Currencies { get; set; }
        public decimal Total { get; set; }
    }
}
