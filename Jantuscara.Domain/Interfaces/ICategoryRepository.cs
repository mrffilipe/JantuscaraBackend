using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category?> GetByIdAsync(Guid id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category?> GetByDescriptionAsync(string description);

        Task<IEnumerable<Recipe>> GetRecipesByCategoryIdAsync(Guid categoryId);
        Task<int> CountRecipesInCategoryAsync(Guid categoryId);

        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(Guid id);

        Task<bool> ExistsByDescriptionAsync(string description);
    }
}
