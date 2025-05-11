using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class RecipeIngredient : BaseEntity
    {
        public Guid RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }

        public Guid IngredientId { get; private set; }
        public Ingredient Ingredient { get; private set; }

        public double Quantity { get; private set; }
        public string Unit { get; private set; }

        private RecipeIngredient()
        {
        }

        public RecipeIngredient(Guid ingredientId, double quantity, string unit)
        {
            IngredientId = ingredientId;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
