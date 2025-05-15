using Jantuscara.Application.DTOs.Book;
using Jantuscara.Application.DTOs.Category;
using Jantuscara.Application.Interfaces.UseCases.Category;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Category
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryByIdUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<CategoryDto?> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetCategoryByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Categoria não encontrada.");
            }

            return new CategoryDto
            {
                Id = result.Id,
                Description = result.Description
            };
        }
    }
}
