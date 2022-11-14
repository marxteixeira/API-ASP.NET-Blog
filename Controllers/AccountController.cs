using Blog.Extentions;
using Blog.Models;
using Blog.Services;
using Blog.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("v1/accounts")]
        public async Task<IActionResult> Post(
            [FromBody] RegisterViewModel model,
            [FromServices] TokenService _tokenService
            )
        {
            if(!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                Slug = model.Email.Replace("@", "-").Replace(".", "-")
            };

            return Ok();
        }

        [HttpPost("v1/accounts/login")]
        public IActionResult Login([FromServices]TokenService _tokenService)
        {
            var token = _tokenService.GenerateToken(null);
            return Ok(token);
        }

        


    }
}
