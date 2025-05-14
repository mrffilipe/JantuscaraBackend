using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.Ingredient
{
    public record IngredientDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Message => $"Ingrediente '{Name}' listado com sucesso!";
    }
}
