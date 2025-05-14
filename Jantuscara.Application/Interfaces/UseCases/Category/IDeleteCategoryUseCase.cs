using Jantuscara.Application.Common;

namespace Jantuscara.Application.Interfaces.UseCases.Category
{
    public interface IDeleteCategoryUseCase
    {
        Task<IMessageResponse> ExecuteAsync(Guid id);
    }
}