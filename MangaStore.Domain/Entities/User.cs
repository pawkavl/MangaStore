namespace MangaStore.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; } = 0;
        public string Password { get; set; } = null!;
    }
}
