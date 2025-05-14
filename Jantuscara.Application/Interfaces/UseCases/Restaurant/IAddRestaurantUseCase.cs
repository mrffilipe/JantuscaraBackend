using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Restaurant;

namespace Jantuscara.Application.Interfaces.UseCases.Restaurant
{
    public interface IAddRestaurantUseCase
    {
        Task<IMessageResponse> ExecuteAsync(AddRestaurantDto dto);
    }
}