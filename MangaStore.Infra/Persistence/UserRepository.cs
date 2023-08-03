using MangaStore.Application.Shared.Interfaces.Persistence;
using MangaStore.Domain.Entities;

namespace MangaStore.Infra.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? getUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }
    }
}
