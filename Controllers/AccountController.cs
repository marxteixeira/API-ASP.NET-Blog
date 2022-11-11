using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("v1/login")]
        public IActionResult Login([FromServices]TokenService _tokenService)
        {
            var token = _tokenService.GenerateToken(null);
            return Ok(token);
        }

    }
}
