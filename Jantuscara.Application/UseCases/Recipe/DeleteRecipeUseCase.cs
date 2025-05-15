using Jantuscara.Application.Common;
using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Recipe
{
    public class DeleteRecipeUseCase : IDeleteRecipeUseCase
    {
        private readonly IRecipeRepository _repository;

        public DeleteRecipeUseCase(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetRecipeByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Receita não encontrada.");
            }

            _repository.DeleteRecipeAsync(result);
            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Receita '{result.Name}' deletada com sucesso!"
            };
        }
    }
}
