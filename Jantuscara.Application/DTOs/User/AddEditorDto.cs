namespace Jantuscara.Application.DTOs.User
{
    public record AddEditorDto
    {
        public string Name { get; set; }
        public DateOnly ContractDate { get; set; }
    }
}
