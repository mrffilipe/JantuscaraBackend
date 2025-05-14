using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.User
{
    public record ChefDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateOnly ContractDate { get; set; }
        public string TradeName { get; set; }
        public Guid RestaurantId { get; set; }

        public string Message => $"Cozinheiro '{Name}' listado com sucesso!";
    }
}
