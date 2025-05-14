using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;

        public ICollection<RecipeIngredient> Recipes { get; private set; } = [];

        private Ingredient()
        {
        }

        public Ingredient(string name)
        {
            Name = name;
        }

        public void UpdateName(string name)
        {
            Name = name;
        }
    }
}
