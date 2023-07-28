namespace MangaStore.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResult Register(string loginName, int age, string email, string password);

        AuthenticationResult Login(string email, string password);        
    }
}
