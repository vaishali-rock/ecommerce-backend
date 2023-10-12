using ECommerce.Models;

namespace ECommerce.Persistence.DBService
{
    public interface IDBUserProfileService
    {
        UserProfile? CreateUserProfile(UserProfile userProfile);
    }
}
