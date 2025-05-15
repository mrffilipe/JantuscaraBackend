using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Category;
using Jantuscara.Application.Interfaces.UseCases.Category;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Category
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private readonly ICategoryRepository _repository;

        public AddCategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(AddCategoryDto dto)
        {
            var newCategory = new Domain.Entities.Category(dto.Description);

            await _repository.AddCategoryAsync(newCategory);

            return new MessageResponse
            {
                Message = $"Categoria '{dto.Description}' criada com sucesso!"
            };
        }
    }
}
