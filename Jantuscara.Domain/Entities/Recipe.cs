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

        public void UpdateInfo(string name, DateOnly creationDate)
        {
            Name = name;
            CreationDate = creationDate;
        }

        public void AddTaster(Taster taster)
        {
            if (taster is null)
                throw new ArgumentNullException(nameof(taster), "Degustador não pode ser nulo.");

            if (Tasters.Any(rt => rt.TasterId == taster.Id))
                throw new InvalidOperationException("Este degustador já está associado à receita.");

            Tasters.Add(new RecipeTaster(this, taster));
        }

        public void AddIngredient(RecipeIngredient ingredient)
        {
            if (ingredient is null)
                throw new ArgumentNullException(nameof(ingredient), "Ingrediente não pode ser nulo.");

            if (ingredient.Quantity <= 0)
                throw new ArgumentException("A quantidade do ingrediente deve ser maior que zero.");

            if (string.IsNullOrWhiteSpace(ingredient.Unit))
                throw new ArgumentException("A unidade de medida do ingrediente é obrigatória.");

            if (Ingredients.Any(i => i.IngredientId == ingredient.IngredientId))
                throw new InvalidOperationException("Este ingrediente já foi adicionado à receita.");

            Ingredients.Add(ingredient);
        }
    }
}
