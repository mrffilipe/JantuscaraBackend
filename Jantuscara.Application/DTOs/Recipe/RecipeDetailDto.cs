using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.Recipe
{
    public record RecipeDetailDto : IMessageResponse
    {
        public string RecipeName { get; set; } = string.Empty;
        public DateOnly CreationDate { get; set; }
        public string Category { get; set; } = string.Empty;
        public string BookTitle { get; set; } = string.Empty;

        public string Message => $"Receita '{RecipeName}' listada com sucesso!";
    }
}
