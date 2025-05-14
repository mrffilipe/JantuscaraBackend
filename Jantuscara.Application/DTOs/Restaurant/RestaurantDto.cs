using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.Restaurant
{
    public record RestaurantDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Resume { get; set; }

        public string Message => $"Restaurante '{Name}' listado com sucesso!";
    }
}
