using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Ingredient;

namespace Jantuscara.Application.DTOs.Recipe
{
    public record RecipeDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        public Guid ChefId { get; set; }
        public Guid BookId { get; set; }
        public Guid CategoryId { get; set; }
        public List<IngredientDto> Ingredients { get; set; }

        public string Message => $"Receita '{Name}' listada com sucesso!";
    }
}
