namespace Jantuscara.Application.DTOs.Restaurant
{
    public record UpdateRestaurantDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Resume { get; set; }
    }
}
