using ErrorOr;
using MangaStore.Application.Services.Authentication.Shared;

namespace MangaStore.Application.Services.Authentication.Commands
{
    public interface IAuthenticationCommandService
    {
        ErrorOr<AuthenticationResult> Register(string loginName, int age, string email, string password);
    }
}
