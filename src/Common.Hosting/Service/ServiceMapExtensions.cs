using Common.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Common.Hosting.Service
{
    public static class ServiceMapExtensions
    {
        public static void AddServiceMapByName(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Describe(typeof(IServiceMap<>), typeof(ServiceMapByServiceName<>), ServiceLifetime.Singleton));
        }
    }
}
