namespace Jantuscara.Application.DTOs.Recipe
{
    public record UpdateRecipeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid ChefId { get; set; }
        public Guid CategoryId { get; set; }
        public List<UpdateIngredientDto> Ingredients { get; set; }
    }
}
