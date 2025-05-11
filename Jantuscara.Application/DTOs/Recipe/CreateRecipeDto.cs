namespace Jantuscara.Application.DTOs.Recipe
{
    public record CreateRecipeDto
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid ChefId { get; set; }
        public Guid CategoryId { get; set; }
        public List<IngredientDto> Ingredients { get; set; }
    }
}
