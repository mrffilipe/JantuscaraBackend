using Jantuscara.Application.DTOs.Restaurant;

namespace Jantuscara.Application.Interfaces.UseCases.Restaurant
{
    public interface IGetAllRestaurantsUseCase
    {
        Task<IEnumerable<RestaurantDto>> ExecuteAsync();
    }
}