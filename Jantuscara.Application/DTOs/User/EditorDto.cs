using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.User
{
    public record EditorDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateOnly ContractDate { get; set; }

        public string Message => $"Editor '{Name}' listado com sucesso!";
    }
}
