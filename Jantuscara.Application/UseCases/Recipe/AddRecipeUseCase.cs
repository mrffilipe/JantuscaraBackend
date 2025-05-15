using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Recipe;
using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Recipe
{
    public class AddRecipeUseCase : IAddRecipeUseCase
    {
        private readonly IRecipeRepository _repository;

        public AddRecipeUseCase(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(AddRecipeDto dto)
        {
            var newRecipe = new Domain.Entities.Recipe(
                dto.Name,
                dto.CreationDate,
                dto.ChefId,
                dto.BookId,
                dto.CategoryId);

            // Adiciona os ingredientes
            foreach (var ingredient in dto.Ingredients)
            {
                newRecipe.AddIngredient(new Domain.Entities.RecipeIngredient(
                    newRecipe,
                    ingredient.Id,
                    ingredient.Quantity,
                    ingredient.Unit));
            }

            await _repository.AddRecipeAsync(newRecipe);

            return new MessageResponse
            {
                Message = $"Receita '{dto.Name}' criada com sucesso!"
            };
        }
    }
}
