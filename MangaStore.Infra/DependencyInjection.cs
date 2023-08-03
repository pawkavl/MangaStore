using MangaStore.Application.Shared.Interfaces.Authentication;
using MangaStore.Application.Shared.Interfaces.Persistence;
using MangaStore.Infra.Authentication;
using MangaStore.Infra.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MangaStore.Infra
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfra(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
