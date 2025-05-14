namespace Jantuscara.Application.DTOs.User
{
    public record AddTasterDto
    {
        public string Name { get; set; }
        public DateOnly ContractDate { get; set; }
    }
}
