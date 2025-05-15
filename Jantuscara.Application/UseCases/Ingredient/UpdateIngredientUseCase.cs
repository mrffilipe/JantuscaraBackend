using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Ingredient;
using Jantuscara.Application.Interfaces.UseCases.Ingredient;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Ingredient
{
    public class UpdateIngredientUseCase : IUpdateIngredientUseCase
    {
        private readonly IIngredientRepository _repository;

        public UpdateIngredientUseCase(IIngredientRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(UpdateIngredientDto dto)
        {
            var result = await _repository.GetIngredientByIdAsync(dto.Id);

            if (result == null)
            {
                throw new Exception("Ingrediente não encontrado.");
            }

            result.UpdateName(dto.Name);

            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Ingrediente '{dto.Name}' atualizado com sucesso!"
            };
        }
    }
}
