using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.User
{
    public record TasterDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateOnly ContractDate { get; set; }

        public string Message => $"Degustador '{Name}' listado com sucesso!";
    }
}
