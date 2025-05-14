using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Category;

namespace Jantuscara.Application.Interfaces.UseCases.Category
{
    public interface IUpdateCategoryUseCase
    {
        Task<IMessageResponse> ExecuteAsync(UpdateCategoryDto dto);
    }
}