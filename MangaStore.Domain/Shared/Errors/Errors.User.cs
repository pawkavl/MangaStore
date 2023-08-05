using ErrorOr;

namespace MangaStore.Domain.Shared.Errors
{
    public static partial class Errors
    {
        public static class User
        {
            public static Error DuplicateEmail = Error.Conflict(
                code: "User.DuplicateEmail",
                description: "Can't use existed email.");
        }
    }
}
