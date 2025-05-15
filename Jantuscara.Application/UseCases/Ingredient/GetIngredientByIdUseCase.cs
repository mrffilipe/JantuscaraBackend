using Jantuscara.Application.DTOs.Ingredient;
using Jantuscara.Application.Interfaces.UseCases.Ingredient;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Ingredient
{
    public class GetIngredientByIdUseCase : IGetIngredientByIdUseCase
    {
        private readonly IIngredientRepository _repository;

        public GetIngredientByIdUseCase(IIngredientRepository repository)
        {
            _repository = repository;
        }

        public async Task<IngredientDto?> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetIngredientByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Ingrediente não encontrado.");
            }

            return new IngredientDto
            {
                Id = result.Id,
                Name = result.Name
            };
        }
    }
}
