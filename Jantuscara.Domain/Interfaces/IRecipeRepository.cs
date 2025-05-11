using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IRecipeRepository
    {
        Task<Recipe?> GetByIdAsync(Guid id);
        Task<IEnumerable<Recipe>> GetAllAsync();
        Task<IEnumerable<Recipe>> GetByCategoryAsync(Guid categoryId);
        Task<IEnumerable<Recipe>> GetByChefIdAsync(Guid chefId);
        Task<IEnumerable<Recipe>> GetByBookIdAsync(Guid bookId);

        Task AddAsync(Recipe recipe);
        Task UpdateAsync(Recipe recipe);
        Task DeleteAsync(Guid id);

        Task<bool> ExistsByNameAsync(string name);
        Task<bool> IsRecipeTestedAsync(Guid recipeId);
    }
}
