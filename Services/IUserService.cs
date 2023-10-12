using ECommerce.Models;

namespace ECommerce.Services
{
    public interface IUserService
    {
        UserProfile? CreateUserProfile(UserProfile userProfile);

        string AuthenticateUser(UserCredentials userCredentials);
    }
}
