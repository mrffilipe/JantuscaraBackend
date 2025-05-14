using Jantuscara.Application.DTOs.Category;

namespace Jantuscara.Application.Interfaces.UseCases.Category
{
    public interface IGetCategoryByIdUseCase
    {
        Task<CategoryDto?> ExecuteAsync(Guid id);
    }
}