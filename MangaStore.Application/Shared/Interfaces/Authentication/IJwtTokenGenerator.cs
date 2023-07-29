namespace MangaStore.Application.Shared.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Guid userId, string loginName, string email);
    }
}
