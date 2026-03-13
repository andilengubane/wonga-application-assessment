using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using WongaApplication.Domain.Options;
using WongaApplication.Domain.Interface;
using WongaApplication.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using WongaApplication.Infrastructure.Repository;

namespace WongaApplication.Infrastructure
{
    public static class InfrastructureDependancyRegister
    {
        public static IServiceCollection AddInfastractureDependancyInjections(this IServiceCollection services)
        {
            services.AddDbContext<WongaApplicationContext>((provider, option) =>
            {
                option.UseNpgsql(provider.GetRequiredService<IOptionsSnapshot<ConnectioStringOptions>>().Value.PostgressConnectionString);
            });

            services.AddScoped<DbContext, WongaApplicationContext>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
