using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Ingredient;
using Jantuscara.Application.Interfaces.UseCases.Ingredient;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Ingredient
{
    public class AddIngredientUseCase : IAddIngredientUseCase
    {
        private readonly IIngredientRepository _repository;

        public AddIngredientUseCase(IIngredientRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(AddIngredientDto dto)
        {
            var newIngredient = new Domain.Entities.Ingredient(dto.Name);

            await _repository.AddIngredientAsync(newIngredient);

            return new MessageResponse
            {
                Message = $"Ingrediente '{dto.Name}' criado com sucesso!"
            };
        }
    }
}
