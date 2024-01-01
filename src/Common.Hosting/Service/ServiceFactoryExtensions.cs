using Common.Hosting.ServiceProvider;
using Common.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Hosting.Service
{
    public static class ServiceFactoryExtensions
    {
        public static void AddTransientFactory<TService, TServiceFactory>(this IServiceCollection services)
            where TServiceFactory : class, IServiceFactory<TService>
            where TService : class
        {
            services.AddSingleton<IServiceFactory<TService>, TServiceFactory>();
        }

        public static void AddTransientFactory<TService>(this IServiceCollection services)
            where TService : class
        {
            services.AddSingleton<IServiceFactory<TService>>(
                provider => new ServiceFactoryByFunc<TService>(
                    () => provider.CreateService<TService>()
                )
            );
        }
    }
}
