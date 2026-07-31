namespace NetflixClone.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using NetflixClone.Application.UseCases.auth;
[ApiController]
[Route("auth")]

public class AuthController : ControllerBase
{
    private readonly LoginUserUseCase _loginUserUseCase;

    public AuthController(LoginUserUseCase loginUserUseCase)
    {
        _loginUserUseCase = loginUserUseCase;
    }

   [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var response = await _loginUserUseCase.Execute(request);

        return Ok(response);
    }
}
