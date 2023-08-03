using MangaStore.Domain.Entities;

namespace MangaStore.Application.Shared.Interfaces.Persistence
{
    public interface IUserRepository
    {
        void Add(User user);
        User? getUserByEmail(string email);
    }
}
