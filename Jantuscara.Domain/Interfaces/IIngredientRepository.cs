using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IIngredientRepository
    {
        Task AddIngredientAsync(Ingredient ingredient);
        Task<Ingredient?> GetIngredientByIdAsync(Guid ingredientId);
        Task<IEnumerable<Ingredient>> GetAllIngredientsAsync();
        void DeleteIngredientAsync(Ingredient ingredient);
        Task SaveChangesAsync();
    }
}
