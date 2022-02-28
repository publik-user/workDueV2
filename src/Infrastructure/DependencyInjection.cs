using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("CommanderConnectionSqlServer");
            services.AddDbContext<CommanderContext>(options =>
               options.UseSqlServer(defaultConnectionString));

            services.AddScoped<ICommanderRepo, SqlCommanderRepo>();

            return services;
        }
    }
}