namespace MangaStore.Infra.Authentication
{
    public class JwtSettings
    {
        public const string SectionName = "JwtSettings";
        public string Secret { get; init; } = null!;
        public string Issuer { get; init; } = null!;
        public int Expiry { get; init; }
        public string Audience { get; init; } = null!;

    }          
}              
