using Jantuscara.Application.DTOs.Recipe;

namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface IGetRecipeByIdUseCase
    {
        Task<RecipeDetailsDto?> ExecuteAsync(Guid id);
    }
}
