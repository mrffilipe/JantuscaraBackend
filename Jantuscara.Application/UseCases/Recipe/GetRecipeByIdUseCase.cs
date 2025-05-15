using Jantuscara.Application.DTOs.Ingredient;
using Jantuscara.Application.DTOs.Recipe;
using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Recipe
{
    public class GetRecipeByIdUseCase : IGetRecipeByIdUseCase
    {
        private readonly IRecipeRepository _repository;

        public GetRecipeByIdUseCase(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public async Task<RecipeDto?> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetRecipeByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Receita não encontrada.");
            }

            return new RecipeDto
            {
                Id = result.Id,
                Name = result.Name,
                CreationDate = result.CreationDate,
                ChefId = result.ChefId,
                BookId = result.BookId,
                CategoryId = result.CategoryId,
                Ingredients = result.Ingredients.Select(i => new IngredientDto
                {
                    Id = i.Ingredient.Id,
                    Name = i.Ingredient.Name
                }).ToList()
            };
        }
    }
}
