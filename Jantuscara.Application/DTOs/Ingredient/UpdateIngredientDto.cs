namespace Jantuscara.Application.DTOs.Ingredient
{
    public record UpdateIngredientDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
