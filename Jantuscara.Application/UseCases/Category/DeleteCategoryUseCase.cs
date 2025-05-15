using Jantuscara.Application.Common;
using Jantuscara.Application.Interfaces.UseCases.Category;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Category
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository _repository;

        public DeleteCategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetCategoryByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Categoria não encontrada.");
            }

            _repository.DeleteCategoryAsync(result);
            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Categoria '{result.Description}' deletada com sucesso!"
            };
        }
    }
}
