using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.Category
{
    public record CategoryDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public string Message => $"Categoria '{Description}' listada com sucesso!";
    }
}
