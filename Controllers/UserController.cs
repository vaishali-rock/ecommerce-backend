using ECommerce.Models;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerce.Controllers
{
    [Route("api/user/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //Post Request to Create User Profile into the system.
        [HttpPost]
        [Route("create")]
        public ActionResult Post([FromBody] UserProfile userProfile)
        {
            // Validation
            if (userProfile == null)
                return BadRequest("Please provide valid input data");

            //Call appropriate service layer to talk with DB
            var createUserProfileResult = _userService.CreateUserProfile(userProfile);
            return createUserProfileResult != null ?  Ok(userProfile) : BadRequest("UserProfile creation failed.");
        }

        // Post Request to Authenticate the User. 
        [HttpPost]
        [Route("authorize")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


    }
}
