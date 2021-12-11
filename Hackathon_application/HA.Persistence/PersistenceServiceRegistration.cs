using HA.Application.Contracts.Persistence;
using HA.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HA.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("HackathonAppConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IZoneRepository, ZoneRepository>();
            services.AddScoped<IPriceMultiplierRepository, PriceMultiplierRepository>();
            services.AddScoped<ISurveyFirstRepository, SurveyFirstRepository>();
            services.AddScoped<ISurveySecondRepository, SurveySecondRepository>();

            return services;
        }
    }
}
