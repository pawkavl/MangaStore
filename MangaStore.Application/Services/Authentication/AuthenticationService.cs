using MangaStore.Application.Shared.Interfaces.Authentication;

namespace MangaStore.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Register(string loginName, int age, string email, string password)
        {

            var userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, loginName, email);

            return new AuthenticationResult(
                userId,
                loginName,
                age,
                email,
                token
            );
        }

        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                "loginName",
                30,
                email,
                "Token"
            );
        }
    }
}
