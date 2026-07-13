namespace NetflixClone.API.Controllers;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("auth")]

public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok();
    }
}
