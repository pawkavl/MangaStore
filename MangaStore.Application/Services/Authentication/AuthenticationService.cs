﻿using ErrorOr;
using MangaStore.Application.Shared.Interfaces.Authentication;
using MangaStore.Application.Shared.Interfaces.Persistence;
using MangaStore.Domain.Entities;
using MangaStore.Domain.Shared.Errors;

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

        public ErrorOr<AuthenticationResult> Login(string email, string password)
        {
            if (_userRepository.getUserByEmail(email) is not User user)
            {
                return Errors.Authentication.InvalidCredentials;
            }

            if (user.Password != password)
            {
                return Errors.Authentication.InvalidCredentials;
            }

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token
            );
        }
    }
}
