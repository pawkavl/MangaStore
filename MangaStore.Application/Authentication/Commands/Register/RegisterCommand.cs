using ErrorOr;
using MangaStore.Application.Authentication.Shared;
using MediatR;

namespace MangaStore.Application.Authentication.Commands.Register
{
    public record RegisterCommand
    (
        string LoginName,
        int Age,
        string Email,
        string Password
     ) : IRequest<ErrorOr<AuthenticationResult>>;

}
