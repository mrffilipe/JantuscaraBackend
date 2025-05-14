using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class RecipeTaster : BaseEntity
    {
        public Guid RecipeId { get; private set; }
        public Recipe Recipe { get; private set; } = null!;
        public Guid TasterId { get; private set; }
        public Taster Taster { get; private set; } = null!;

        private RecipeTaster()
        {
        }

        public RecipeTaster(Recipe recipe, Taster taster)
        {
            Recipe = recipe;
            Taster = taster;
        }
    }
}
