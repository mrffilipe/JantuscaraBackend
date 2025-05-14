using Jantuscara.Application.DTOs.Category;

namespace Jantuscara.Application.Interfaces.UseCases.Category
{
    public interface IGetAllCategoriesUseCase
    {
        Task<IEnumerable<CategoryDto>> ExecuteAsync();
    }
}