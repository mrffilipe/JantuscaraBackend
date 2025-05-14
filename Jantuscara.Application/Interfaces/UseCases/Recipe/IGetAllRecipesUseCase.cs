using Jantuscara.Application.DTOs.Recipe;

namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface IGetAllRecipesUseCase
    {
        Task<IEnumerable<RecipeDto>> ExecuteAsync();
    }
}
