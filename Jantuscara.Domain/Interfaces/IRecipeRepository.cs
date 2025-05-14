using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IRecipeRepository
    {
        Task AddRecipeAsync(Recipe recipe);
        Task<Recipe?> GetRecipeByIdAsync(Guid recipeId);
        Task<IEnumerable<Recipe>> GetAllRecipesAsync();
        void DeleteRecipeAsync(Recipe recipe);
        Task SaveChangesAsync();
    }
}
