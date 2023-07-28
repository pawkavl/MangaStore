namespace MangaStore.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Register(string loginName, int age, string email, string password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                loginName,
                age,
                email,
                "Token"
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
