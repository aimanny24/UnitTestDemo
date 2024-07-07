namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        // a property which specifies the user that makes the reservation
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin || MadeBy == user);
        }
        
    }

    // a User class with one property
    public class User
    {
        public bool IsAdmin { get; set; }
    }
}