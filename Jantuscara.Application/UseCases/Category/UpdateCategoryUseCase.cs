using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Category;
using Jantuscara.Application.Interfaces.UseCases.Category;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Category
{
    public class UpdateCategoryUseCase : IUpdateCategoryUseCase
    {
        private readonly ICategoryRepository _repository;

        public UpdateCategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(UpdateCategoryDto dto)
        {
            var result = await _repository.GetCategoryByIdAsync(dto.Id);

            if (result == null)
            {
                throw new Exception("Categoria não encontrada.");
            }

            result.UpdateDescription(dto.Description);

            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Categoria '{dto.Description}' atualizada com sucesso!"
            };
        }
    }
}
