using MangaStore.Application.Shared.Interfaces.Authentication;
using MangaStore.Application.Shared.Interfaces.Persistence;
using MangaStore.Domain.Entities;

namespace MangaStore.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Register(string loginName, int age, string email, string password)
        {
            if (_userRepository.getUserByEmail(email) is not null)
            {
                throw new Exception("User with given email already exists.");
            }

            var user = new User { LoginName = loginName, Email = email, Age = age, Password = password };
            _userRepository.Add(user);

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token
            );
        }

        public AuthenticationResult Login(string email, string password)
        {
            if (_userRepository.getUserByEmail(email) is not User user)
            {
                throw new Exception("User with given email does not exist.");
            }

            if (user.Password != password)
            {
                throw new Exception("Invalid login/password.");
            }

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token
            );
        }
    }
}
