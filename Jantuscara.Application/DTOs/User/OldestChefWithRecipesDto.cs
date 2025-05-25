using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Recipe;

namespace Jantuscara.Application.DTOs.User
{
    public record OldestChefWithRecipesDto : IMessageResponse
    {
        public string ChefName { get; set; } = string.Empty;
        public DateOnly ContractDate { get; set; }
        public string RestaurantName { get; set; } = string.Empty;
        public List<RecipeDetailDto> Recipes { get; set; } = new();

        public string Message => $"Cozinheiro '{ChefName}' listado com sucesso!";
    }
}
