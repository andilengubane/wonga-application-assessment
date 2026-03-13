using MediatR.NotificationPublishers;
using Microsoft.Extensions.DependencyInjection;

namespace WongaApplication.Application
{
    public static class ApplicationDependancyRegister
    {
        public static IServiceCollection AddApplicationDependacyInjection(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(ApplicationDependancyRegister).Assembly);
                cfg.NotificationPublisher = new ForeachAwaitPublisher();
            });
            return services;
        }
    }
}
