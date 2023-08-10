namespace MangaStore.Contracts.Authentication
{
    public record AuthenticationResponse(
        Guid Id,
        string LoginName,
        int Age,
        string Email,
        string Token
    );
}
