using Jantuscara.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jantuscara.Infrastructure.Configurations
{
    public static class DbContextConfiguration
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection")
                                       ?? throw new Exception("Variável de ambiente 'DefaultConnection' não encontrada");

                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            return services;
        }
    }
}
