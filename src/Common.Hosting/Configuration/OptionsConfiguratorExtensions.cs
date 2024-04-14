using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Common.Hosting.Configuration
{
    public static class OptionsConfiguratorExtensions
    {
        public static void ConfigureByName<TOptions>(this IServiceCollection services, bool required = false)
            where TOptions : class, new()
        {
            services.AddOptions();

            services.AddTransient<IConfigureOptions<TOptions>>(p =>
                new OptionsConfigurator<TOptions>(
                    p.GetRequiredService<IConfiguration>(),
                    required
                )
            );
        }
    }
}
