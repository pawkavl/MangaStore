using ErrorOr;

namespace MangaStore.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        ErrorOr<AuthenticationResult> Register(string loginName, int age, string email, string password);

        ErrorOr<AuthenticationResult> Login(string email, string password);        
    }
}
