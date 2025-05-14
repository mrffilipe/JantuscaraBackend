using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Recipe : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public DateOnly CreationDate { get; private set; }

        public Guid ChefId { get; private set; }
        public Chef Chef { get; private set; } = null!;

        public Guid BookId { get; private set; }
        public Book Book { get; private set; } = null!;

        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; } = null!;

        public ICollection<RecipeIngredient> Ingredients { get; private set; } = [];
        public ICollection<RecipeTaster> Tasters { get; private set; } = [];

        private Recipe()
        {
        }

        public Recipe(
            string name,
            DateOnly creationDate,
            Guid chefId,
            Guid bookId,
            Guid categoryId)
        {
            Name = name;
            CreationDate = creationDate;
            ChefId = chefId;
            BookId = bookId;
            CategoryId = categoryId;
        }

        public void AddTaster(Taster taster)
        {
            Tasters.Add(new RecipeTaster(this, taster)); // validar
        }

        public void AddIngredient(RecipeIngredient ingredient)
        {
            // validar
            Ingredients.Add(ingredient);
        }
    }
}
