using Jantuscara.Application.DTOs.Recipe;

namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface IGetRecipeByIdUseCase
    {
        Task<RecipeDto?> ExecuteAsync(Guid id);
    }
}
