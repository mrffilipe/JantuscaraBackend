using Jantuscara.Application.DTOs.Recipe;
using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.Ingredient.Query;
using Microsoft.EntityFrameworkCore;

namespace Jantuscara.Infrastructure.Persistence.Repositories
{
    public class UserQueryRepository : IUserQueryRepository
    {
        private readonly ApplicationDbContext _context;

        public UserQueryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OldestChefWithRecipesDto>> GetOldestChefsWithRecipesAndBooksAsync()
        {
            // Primeiro: encontra a menor data de contrato
            var oldestContractDate = await _context.Chefs
                .MinAsync(c => c.ContractDate);

            // Segundo: busca todos os chefs com essa data
            var result = await _context.Chefs
                .Where(c => c.ContractDate == oldestContractDate)
                .Include(c => c.Restaurant)
                .Include(c => c.Recipes)
                    .ThenInclude(r => r.Category)
                .Include(c => c.Recipes)
                    .ThenInclude(r => r.Book)
                .ToListAsync();

            // Projeta para o DTO final
            return result.Select(chef => new OldestChefWithRecipesDto
            {
                ChefName = chef.Name,
                ContractDate = chef.ContractDate,
                RestaurantName = chef.Restaurant.Name,
                Recipes = chef.Recipes.Select(r => new RecipeDetailDto
                {
                    RecipeName = r.Name,
                    CreationDate = r.CreationDate,
                    Category = r.Category.Description,
                    BookTitle = r.Book.Title
                }).ToList()
            }).ToList();
        }
    }
}
