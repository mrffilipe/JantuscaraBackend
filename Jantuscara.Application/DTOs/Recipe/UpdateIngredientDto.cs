namespace Jantuscara.Application.DTOs.Recipe
{
    public record UpdateIngredientDto : IngredientDto
    {
        public Guid Id { get; set; }
    }
}