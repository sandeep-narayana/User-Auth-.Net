using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace User_Auth_.Net.Controllers
{
    [ApiController]
    [Route("api/welcome")]
    public class UserAuth : ControllerBase
    {
        private readonly ILogger<UserAuth> _logger;

        public UserAuth(ILogger<UserAuth> logger)
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
