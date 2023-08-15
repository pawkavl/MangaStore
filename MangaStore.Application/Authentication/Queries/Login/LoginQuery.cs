using ErrorOr;
using MangaStore.Application.Authentication.Shared;
using MediatR;

namespace MangaStore.Application.Authentication.Queries.Login
{
    public record LoginQuery(
        string Email,
        string Password
    ) : IRequest<ErrorOr<AuthenticationResult>>;
}
