using Jantuscara.Application.DTOs.Ingredient;

namespace Jantuscara.Application.Interfaces.UseCases.Ingredient.Query
{
    public interface IIngredientQueryRepository
    {
        public Task<IEnumerable<IngredientCategoryCountDto>> GetRecipeCountByIngredientGroupedByCategoryAsync(Guid id);
    }
}
