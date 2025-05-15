using Jantuscara.Application.Interfaces.UseCases.Book;
using Jantuscara.Application.Interfaces.UseCases.Restaurant;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Application.UseCases.Book;
using Jantuscara.Application.UseCases.Restaurant;
using Jantuscara.Application.UseCases.User;
using Microsoft.Extensions.DependencyInjection;

namespace Jantuscara.Infrastructure.Extensions
{
    public static class UseCaseExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IAddBookUseCase, AddBookUseCase>();
            services.AddScoped<IDeleteBookUseCase, DeleteBookUseCase>();
            services.AddScoped<IGetAllBooksUseCase, GetAllBooksUseCase>();
            services.AddScoped<IGetBookByIdUseCase, GetBookByIdUseCase>();
            services.AddScoped<IUpdateBookUseCase, UpdateBookUseCase>();

            services.AddScoped<IAddRestaurantUseCase, AddRestaurantUseCase>();
            services.AddScoped<IDeleteRestaurantUseCase, DeleteRestaurantUseCase>();
            services.AddScoped<IGetAllRestaurantsUseCase, GetAllRestaurantsUseCase>();
            services.AddScoped<IGetRestaurantByIdUseCase, GetRestaurantByIdUseCase>();
            services.AddScoped<IUpdateRestaurantUseCase, UpdateRestaurantUseCase>();

            services.AddScoped<IAddChefUseCase, AddChefUseCase>();
            services.AddScoped<IAddEditorUseCase, AddEditorUseCase>();
            services.AddScoped<IAddTasterUseCase, AddTasterUseCase>();
            services.AddScoped<IDeleteChefUseCase, DeleteChefUseCase>();
            services.AddScoped<IDeleteEditorUseCase, DeleteEditorUseCase>();
            services.AddScoped<IDeleteTasterUseCase, DeleteTasterUseCase>();
            services.AddScoped<IGetAllChefsUseCase, GetAllChefsUseCase>();
            services.AddScoped<IGetAllEditorsUseCase, GetAllEditorsUseCase>();
            services.AddScoped<IGetAllTastersUseCase, GetAllTastersUseCase>();
            services.AddScoped<IGetChefByIdUseCase, GetChefByIdUseCase>();
            services.AddScoped<IGetEditorByIdUseCase, GetEditorByIdUseCase>();
            services.AddScoped<IGetTasterByIdUseCase, GetTasterByIdUseCase>();
            services.AddScoped<IUpdateChefUseCase, UpdateChefUseCase>();
            services.AddScoped<IUpdateEditorUseCase, UpdateEditorUseCase>();
            services.AddScoped<IUpdateTasterUseCase, UpdateTasterUseCase>();

            return services;
        }
    }
}
