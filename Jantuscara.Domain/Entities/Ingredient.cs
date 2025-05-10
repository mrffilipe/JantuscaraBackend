using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; private set; }

        public ICollection<RecipeIngredient> Recipes { get; private set; }
    }
}
