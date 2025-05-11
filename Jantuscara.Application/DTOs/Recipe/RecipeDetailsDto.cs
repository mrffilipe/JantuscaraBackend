using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.Recipe
{
    public record RecipeDetailsDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid ChefId { get; set; }
        public Guid CategoryId { get; set; }
        public List<IngredientDto> Ingredients { get; set; }

        public string Message => $"Receita {Name} listada com sucesso!";
    }
}
