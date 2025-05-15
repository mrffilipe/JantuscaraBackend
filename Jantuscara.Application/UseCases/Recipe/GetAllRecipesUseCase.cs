using Jantuscara.Application.DTOs.Recipe;
using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Recipe
{
    public class GetAllRecipesUseCase : IGetAllRecipesUseCase
    {
        private readonly IRecipeRepository _repository;

        public GetAllRecipesUseCase(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<RecipeDto>> ExecuteAsync()
        {
            var result = await _repository.GetAllRecipesAsync();

            return result.Select(r => new RecipeDto
            {
                Id = r.Id,
                Name = r.Name,
                CreationDate = r.CreationDate,
                ChefId = r.ChefId,
                BookId = r.BookId,
                CategoryId = r.CategoryId,
                Ingredients = null!
            });
        }
    }
}
