using Microsoft.Extensions.DependencyInjection;

namespace Common.Hosting.DependencyInjection
{
    public static class ServiceProviderExtensions
    {
        public static TImplementation CreateService<TImplementation>(this IServiceProvider provider)
        {
            return ActivatorUtilities.CreateInstance<TImplementation>(provider);
        }
    }
}
