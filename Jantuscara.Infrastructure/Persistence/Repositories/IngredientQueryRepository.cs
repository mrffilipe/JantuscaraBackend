using Jantuscara.Application.DTOs.Ingredient;
using Jantuscara.Application.Interfaces.UseCases.Ingredient.Query;
using Microsoft.EntityFrameworkCore;

namespace Jantuscara.Infrastructure.Persistence.Repositories
{
    public class IngredientQueryRepository : IIngredientQueryRepository
    {
        private readonly ApplicationDbContext _context;

        public IngredientQueryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IngredientCategoryCountDto>> GetRecipeCountByIngredientGroupedByCategoryAsync(Guid ingredientId)
        {
            return await _context.RecipeIngredients
                .Where(ri => ri.IngredientId == ingredientId)
                .GroupBy(ri => new
                {
                    IngredientName = ri.Ingredient.Name,
                    CategoryName = ri.Recipe.Category.Description
                })
                .Select(g => new IngredientCategoryCountDto
                {
                    Ingredient = g.Key.IngredientName,
                    Category = g.Key.CategoryName,
                    RecipeCount = g.Select(ri => ri.RecipeId).Distinct().Count()
                })
                .ToListAsync();
        }
    }
}
