namespace Jantuscara.Application.DTOs.User
{
    public record UpdateChefDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateOnly ContractDate { get; set; }
        public string TradeName { get; set; }
    }
}
