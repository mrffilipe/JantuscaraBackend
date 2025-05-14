using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class RecipeIngredient : BaseEntity
    {
        public Guid RecipeId { get; private set; }
        public Recipe Recipe { get; private set; } = null!;

        public Guid IngredientId { get; private set; }
        public Ingredient Ingredient { get; private set; } = null!;

        public double Quantity { get; private set; }
        public string Unit { get; private set; } = string.Empty;

        private RecipeIngredient()
        {
        }

        public RecipeIngredient(
            Recipe recipe,
            Ingredient ingredient,
            double quantity,
            string unit)
        {
            Recipe = recipe;
            Ingredient = ingredient;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
