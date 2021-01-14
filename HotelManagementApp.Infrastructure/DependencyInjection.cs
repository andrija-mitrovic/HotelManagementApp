using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.ConfigureDatabase(config);
            services.ConfigureInjection();

            return services;
        }

        private static void ConfigureDatabase(this IServiceCollection services, IConfiguration config)
        {

        }

        private static void ConfigureInjection(this IServiceCollection services)
        {

        }
    }
}
