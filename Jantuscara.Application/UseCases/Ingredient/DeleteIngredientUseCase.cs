using Jantuscara.Application.Common;
using Jantuscara.Application.Interfaces.UseCases.Ingredient;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Ingredient
{
    public class DeleteIngredientUseCase : IDeleteIngredientUseCase
    {
        private readonly IIngredientRepository _repository;

        public DeleteIngredientUseCase(IIngredientRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetIngredientByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Ingrediente não encontrado.");
            }

            _repository.DeleteIngredientAsync(result);
            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Ingrediente '{result.Name}' deletado com sucesso!"
            };
        }
    }
}
