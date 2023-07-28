using MangaStore.Application.Services.Authentication;
using MangaStore.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace MangaStore.Api.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(request.LoginName, request.Age, request.Email, request.Password);
            var response = new AuthenticationResponse(authResult.Id, authResult.LoginName, authResult.Age, authResult.Email, authResult.Token);
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(request.Email, request.Password);
            var response = new AuthenticationResponse(authResult.Id, authResult.LoginName, authResult.Age, authResult.Email, authResult.Token);
            return Ok(request);
        }
    }
}
