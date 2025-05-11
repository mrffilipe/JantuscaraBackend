using Jantuscara.Application.DTOs.Recipe;
using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Jantuscara.Domain.Entities;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Recipe
{
    public class CreateRecipeUseCase : ICreateRecipeUseCase
    {
        private readonly IRecipeRepository _repository;

        public CreateRecipeUseCase(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> ExecuteAsync(CreateRecipeDto dto)
        {
            var ingredients = new List<RecipeIngredient>();

            foreach (var item in dto.Ingredients)
            {
                ingredients.Add(new RecipeIngredient(item.Id, item.Quantity, item.Unit));
            }

            var recipe = new Domain.Entities.Recipe(dto.Name, dto.CreationDate, ingredients);

            recipe.SetChef(dto.ChefId);
            recipe.SetCategory(dto.CategoryId);

            await _repository.AddAsync(recipe);

            var message = $"Receita {dto.Name} criada com sucesso!";

            return message;
        }
    }
}
