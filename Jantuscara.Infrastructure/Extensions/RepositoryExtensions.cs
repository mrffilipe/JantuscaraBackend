﻿using Jantuscara.Application.Interfaces.UseCases.Ingredient.Query;
using Jantuscara.Domain.Interfaces;
using Jantuscara.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Jantuscara.Infrastructure.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<IIngredientQueryRepository, IngredientQueryRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<IUserQueryRepository, UserQueryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
