using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.ConfigureInjection();

            return services;
        }

        private static void ConfigureInjection(this IServiceCollection services)
        {

        }
    }
}
