using Jantuscara.Application.DTOs.Ingredient;

namespace Jantuscara.Application.Interfaces.UseCases.Ingredient
{
    public interface IGetAllIngredientsUseCase
    {
        Task<IEnumerable<IngredientDto>> ExecuteAsync();
    }
}