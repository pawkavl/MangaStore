using MangaStore.Domain.Entities;

namespace MangaStore.Application.Authentication.Shared
{
    public record AuthenticationResult
    (
        User User,
        string Token
    );
}
