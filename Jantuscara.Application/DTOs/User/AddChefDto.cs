namespace Jantuscara.Application.DTOs.User
{
    public record AddChefDto
    {
        public string Name { get; set; }
        public DateOnly ContractDate { get; set; }
        public string TradeName { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
