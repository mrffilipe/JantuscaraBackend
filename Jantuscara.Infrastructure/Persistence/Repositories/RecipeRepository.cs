using Jantuscara.Domain.Entities;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Infrastructure.Persistence.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _context;

        public RecipeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recipe>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recipe>> GetByBookIdAsync(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recipe>> GetByCategoryAsync(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recipe>> GetByChefIdAsync(Guid chefId)
        {
            throw new NotImplementedException();
        }

        public Task<Recipe?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsRecipeTestedAsync(Guid recipeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
