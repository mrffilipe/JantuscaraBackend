namespace Jantuscara.Application.DTOs.Ingredient
{
    public record IngredientCategoryCountDto
    {
        public string Ingredient { get; set; }
        public string Category { get; set; }
        public int RecipeCount { get; set; }
    }
}
