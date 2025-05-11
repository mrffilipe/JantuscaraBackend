namespace Jantuscara.Application.DTOs.Recipe
{
    public record IngredientDto
    {
        public Guid Id { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }
}
