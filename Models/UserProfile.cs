namespace ECommerce.Models
{
    public class UserProfile : UserCredentials
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }       
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }

    }
}
