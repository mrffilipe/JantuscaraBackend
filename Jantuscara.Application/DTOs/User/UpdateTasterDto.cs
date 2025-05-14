namespace Jantuscara.Application.DTOs.User
{
    public record UpdateTasterDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateOnly ContractDate { get; set; }
    }
}
