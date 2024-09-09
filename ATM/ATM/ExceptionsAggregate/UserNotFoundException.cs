namespace ATM.ExceptionsAggregate
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) :base(message) { }
    }
}
