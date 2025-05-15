using Jantuscara.Application.DTOs.Ingredient;
using Jantuscara.Application.Interfaces.UseCases.Ingredient;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Ingredient
{
    public class GetAllIngredientsUseCase : IGetAllIngredientsUseCase
    {
        private readonly IIngredientRepository _repository;

        public GetAllIngredientsUseCase(IIngredientRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<IngredientDto>> ExecuteAsync()
        {
            var result = await _repository.GetAllIngredientsAsync();

            return result.Select(r => new IngredientDto
            {
                Id = r.Id,
                Name = r.Name
            });
        }
    }
}
