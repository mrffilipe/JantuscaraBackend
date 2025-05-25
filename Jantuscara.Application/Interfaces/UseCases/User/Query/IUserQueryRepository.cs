using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.Ingredient.Query
{
    public interface IUserQueryRepository
    {
        public Task<IEnumerable<OldestChefWithRecipesDto>> GetOldestChefsWithRecipesAndBooksAsync();
    }
}
