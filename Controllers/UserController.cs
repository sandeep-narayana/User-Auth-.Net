// step 2 create controller
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace User_Auth_.Net.Controllers
{
    [ApiController]
    [Route("api/welcome")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<string> Get()
        {
            return Ok("Hello user, you are authenticated.");
        }

        [HttpGet("Auth")]
        public ActionResult<string> GetUserAuth()
        {
            return "Hello user, you are authenticated.";
        }

        
    }
}
