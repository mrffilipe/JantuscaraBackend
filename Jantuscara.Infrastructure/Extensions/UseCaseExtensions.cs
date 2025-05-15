using Jantuscara.Application.Interfaces.UseCases.Restaurant;
using Jantuscara.Application.UseCases.Restaurant;
using Microsoft.Extensions.DependencyInjection;

namespace Jantuscara.Infrastructure.Extensions
{
    public static class UseCaseExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IAddRestaurantUseCase, AddRestaurantUseCase>();
            services.AddScoped<IDeleteRestaurantUseCase, DeleteRestaurantUseCase>();
            services.AddScoped<IGetAllRestaurantsUseCase, GetAllRestaurantsUseCase>();
            services.AddScoped<IGetRestaurantByIdUseCase, GetRestaurantByIdUseCase>();
            services.AddScoped<IUpdateRestaurantUseCase, UpdateRestaurantUseCase>();

            return services;
        }
    }
}
