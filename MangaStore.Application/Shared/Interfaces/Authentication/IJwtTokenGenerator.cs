using MangaStore.Domain.Entities;

namespace MangaStore.Application.Shared.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
