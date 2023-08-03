using MangaStore.Domain.Entities;

namespace MangaStore.Application.Services.Authentication
{
    public record AuthenticationResult
    (
        User User,
        string Token
    );
}
