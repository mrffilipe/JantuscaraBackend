using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Recipe : BaseEntity
    {
        public string Name { get; private set; }
        public DateTime CreationDate { get; private set; }

        public Guid ChefId { get; private set; }
        public Chef Chef { get; private set; }

        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; }

        public ICollection<Taster> Tasters { get; private set; }
        public ICollection<RecipeIngredient> Ingredients { get; private set; }

        private Recipe()
        {
        }

        public Recipe(string name, DateTime creationDate, ICollection<RecipeIngredient> ingredients)
        {
            Name = name;
            CreationDate = creationDate;
            Ingredients = ingredients;
        }

        public void SetChef(Guid chefId)
        {
            ChefId = chefId;
        }

        public void SetCategory(Guid categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
