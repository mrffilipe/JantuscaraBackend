using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Restaurant;

namespace Jantuscara.Application.Interfaces.UseCases.Restaurant
{
    public interface IUpdateRestaurantUseCase
    {
        Task<IMessageResponse> ExecuteAsync(UpdateRestaurantDto dto);
    }
}