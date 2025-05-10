using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IIngredientRepository
    {
        Task<Ingredient?> GetByIdAsync(Guid id);
        Task<IEnumerable<Ingredient>> GetAllAsync();
        Task<Ingredient?> GetByNameAsync(string name);

        Task<IEnumerable<Recipe>> GetRecipesByIngredientIdAsync(Guid ingredientId);
        Task<int> CountUsageAsync(Guid ingredientId);

        Task AddAsync(Ingredient ingredient);
        Task UpdateAsync(Ingredient ingredient);
        Task DeleteAsync(Guid id);

        Task<bool> ExistsByNameAsync(string name);
    }
}
