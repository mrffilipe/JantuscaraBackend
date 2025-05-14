using Jantuscara.Application.Common;

namespace Jantuscara.Application.Interfaces.UseCases.Restaurant
{
    public interface IDeleteRestaurantUseCase
    {
        Task<IMessageResponse> ExecuteAsync(Guid id);
    }
}