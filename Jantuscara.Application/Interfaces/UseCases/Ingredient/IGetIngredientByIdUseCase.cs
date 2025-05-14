using Jantuscara.Application.DTOs.Ingredient;

namespace Jantuscara.Application.Interfaces.UseCases.Ingredient
{
    public interface IGetIngredientByIdUseCase
    {
        Task<IngredientDto?> ExecuteAsync(Guid id);
    }
}