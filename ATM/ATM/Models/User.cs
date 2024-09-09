using System.ComponentModel.DataAnnotations;

namespace ATM.Models
{
    public class User
    {
        public User(Guid iD, string firstName, string lastName, string identifier, DateTime dob)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Identifier = identifier;
            DOB = dob;
        }

        public Guid ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        [StringLength(11,ErrorMessage ="Identifier must be 11 in length")]
        public string Identifier { get; private set; }
        public string FullName { get { return FirstName + "  "  + LastName; }}
        public DateTime DOB { get; private set; }
        public List<Card> Cards { get; set; } = new();

    }
}
