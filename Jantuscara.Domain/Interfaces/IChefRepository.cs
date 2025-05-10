using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IChefRepository
    {
        Task<Chef?> GetByIdAsync(Guid id);
        Task<IEnumerable<Chef>> GetAllAsync();
        Task<Chef?> GetByTradeNameAsync(string tradeName);
        Task<IEnumerable<Chef>> GetByRestaurantIdAsync(Guid restaurantId);

        Task<IEnumerable<Recipe>> GetRecipesByChefIdAsync(Guid chefId);
        Task<IEnumerable<Restaurant>> GetCurriculumAsync(Guid chefId);

        Task AddAsync(Chef chef);
        Task UpdateAsync(Chef chef);
        Task DeleteAsync(Guid id);

        Task<bool> HasPendingRecipesAsync(Guid chefId);
        Task<int> GetRecipeCountForMonthAsync(Guid chefId, int year, int month);
    }
}
