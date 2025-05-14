using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Category;

namespace Jantuscara.Application.Interfaces.UseCases.Category
{
    public interface IAddCategoryUseCase
    {
        Task<IMessageResponse> ExecuteAsync(AddCategoryDto dto);
    }
}