using Jantuscara.Application.DTOs.Book;
using Jantuscara.Application.DTOs.Category;
using Jantuscara.Application.Interfaces.UseCases.Category;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Category
{
    public class GetAllCategoriesUseCase : IGetAllCategoriesUseCase
    {
        private readonly ICategoryRepository _repository;

        public GetAllCategoriesUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CategoryDto>> ExecuteAsync()
        {
            var result = await _repository.GetAllCategoriesAsync();

            return result.Select(r => new CategoryDto
            {
                Id = r.Id,
                Description = r.Description
            });
        }
    }
}
