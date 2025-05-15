namespace Jantuscara.Application.DTOs.Recipe
{
    public record AddRecipeDto
    {
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        public Guid ChefId { get; set; }
        public Guid BookId { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<RecipeIngredient> Ingredients { get; set; }
    }
}
