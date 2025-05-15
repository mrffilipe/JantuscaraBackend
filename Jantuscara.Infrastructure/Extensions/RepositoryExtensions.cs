using Jantuscara.Domain.Interfaces;
using Jantuscara.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Jantuscara.Infrastructure.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();

            return services;
        }
    }
}
