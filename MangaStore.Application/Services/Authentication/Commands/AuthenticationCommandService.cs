using ErrorOr;
using MangaStore.Application.Services.Authentication.Shared;
using MangaStore.Application.Shared.Interfaces.Authentication;
using MangaStore.Application.Shared.Interfaces.Persistence;
using MangaStore.Domain.Entities;
using MangaStore.Domain.Shared.Errors;

namespace MangaStore.Application.Services.Authentication.Commands
{
    public class AuthenticationCommandService : IAuthenticationCommandService
    {

        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationCommandService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public ErrorOr<AuthenticationResult> Register(string loginName, int age, string email, string password)
        {
            if (_userRepository.getUserByEmail(email) is not null)
            {
                return Errors.User.DuplicateEmail;
            }

            var user = new User { LoginName = loginName, Email = email, Age = age, Password = password };
            _userRepository.Add(user);

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token
            );
        }
    }
}
