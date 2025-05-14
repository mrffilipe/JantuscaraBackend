using Jantuscara.Application.DTOs.Restaurant;

namespace Jantuscara.Application.Interfaces.UseCases.Restaurant
{
    public interface IGetRestaurantByIdUseCase
    {
        Task<RestaurantDto?> ExecuteAsync(Guid id);
    }
}