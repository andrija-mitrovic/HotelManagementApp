using HotelManagementApp.Core.Interfaces.Data;
using HotelManagementApp.Infrastructure.Data;
using HotelManagementApp.Infrastructure.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagementApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.ConfigureInjection();

            return services;
        }

        private static void ConfigureInjection(this IServiceCollection services)
        {
            services.AddScoped<IDataAccess, SqlDataAccess>();
            services.AddScoped<IGuestRepository, GuestRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
        }
    }
}
