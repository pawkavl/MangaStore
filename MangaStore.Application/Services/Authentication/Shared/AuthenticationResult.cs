using MangaStore.Domain.Entities;

namespace MangaStore.Application.Services.Authentication.Shared
{
    public record AuthenticationResult
    (
        User User,
        string Token
    );
}
