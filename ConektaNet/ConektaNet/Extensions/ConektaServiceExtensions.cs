using System;
using System.Collections.Generic;
using System.Text;

using ConektaNet.Models.Configuration;
using ConektaNet.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConektaServiceExtensions
    {
        public static IServiceCollection AddConekta(this IServiceCollection services, Action<Configuration> configuration)
        {
            return services
                .Configure(configuration)
                .AddConekta();
        }

        public static IServiceCollection AddConekta(this IServiceCollection services, Configuration configuration)
        {
            return services
                .Configure<Configuration>(config =>
                {
                    config.ApiKey = config.ApiKey;
                    config.ApiVersion = config.ApiVersion;
                    config.BaseUrl = config.BaseUrl;
                    config.Locale = config.Locale;
                })
                .AddConekta();
        }

        private static IServiceCollection AddConekta(this IServiceCollection services)
        {
            return services
                .AddScoped<IHttpHelper, HttpHelper>();
        }
    }
}
