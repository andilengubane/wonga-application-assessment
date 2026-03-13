using WongaApplication.Domain;
using WongaApplication.Application;
using WongaApplication.Infrastructure;

namespace WongaApplication.Api
{
    public static class WongaApplicationDependacyRegister
    {
        public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDependacyInjection()
                    .AddInfastractureDependancyInjections()
                    .AddDomainDependacyInjection(configuration);

            return services;
        }
    }
}
