namespace MangaStore.Contracts.Authentication
{
    public record RegisterRequest(
        string LoginName,
        int Age,
        string Email,
        string Password
    );

}
