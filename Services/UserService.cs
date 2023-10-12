using ECommerce.Models;
using ECommerce.Persistence.DBService;

namespace ECommerce.Services
{
    public class UserService : IUserService
    {
        private readonly IDBUserProfileService _dBUserProfileService;
        public UserService(IDBUserProfileService dBUserProfileService)
        {
            _dBUserProfileService = dBUserProfileService;
        }
        public UserProfile? CreateUserProfile(UserProfile userProfile)
        {
            //Call DB layer to Save user profile data
            return _dBUserProfileService.CreateUserProfile(userProfile);
        }

        public string AuthenticateUser(UserCredentials userCredentials)
        {
            throw new NotImplementedException();
        }
    }
}
