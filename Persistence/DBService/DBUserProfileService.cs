using ECommerce.Models;
using ECommerce.Persistence.DBModels;

namespace ECommerce.Persistence.DBService
{
    public class DBUserProfileService : IDBUserProfileService
    {
        private readonly ECommerceContext _eCommerceContext;
        public DBUserProfileService(ECommerceContext eCommerceContext)
        {
            _eCommerceContext = eCommerceContext;
        }

        public UserProfile? CreateUserProfile(UserProfile userProfile)
        {
            var dbUserProfile = new DBUserProfile
            {
                Email = userProfile.Email,
                FirstName = userProfile.FirstName,
                LastName = userProfile.LastName,
                Gender = userProfile.Gender,
                Password = userProfile.Password,
                PhoneNumber = userProfile.PhoneNumber
            };

            _eCommerceContext.UserProfile.Add(dbUserProfile);
            var numberOfRows = _eCommerceContext.SaveChanges();
            return numberOfRows == 1 ? userProfile : null;
        }
    }
}
