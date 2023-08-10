using ErrorOr;
using MangaStore.Application.Services.Authentication.Shared;

namespace MangaStore.Application.Services.Authentication.Queries
{
    public interface IAuthenticationQueryService
    {
        ErrorOr<AuthenticationResult> Login(string email, string password);
    }
}
