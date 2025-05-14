using Jantuscara.Domain.Entities;
using Jantuscara.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Jantuscara.Infrastructure.Persistence.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly ApplicationDbContext _context;

        public IngredientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddIngredientAsync(Ingredient ingredient)
        {
            await _context.Ingredients.AddAsync(ingredient);
            await _context.SaveChangesAsync();
        }

        public async Task<Ingredient?> GetIngredientByIdAsync(Guid ingredientId)
        {
            return await _context.Ingredients
                .FirstOrDefaultAsync(i => i.Id == ingredientId);
        }

        public async Task<IEnumerable<Ingredient>> GetAllIngredientsAsync()
        {
            return await _context.Ingredients.ToListAsync();
        }

        public void DeleteIngredientAsync(Ingredient ingredient)
        {
            _context.Ingredients.Remove(ingredient);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
