namespace Jantuscara.Application.DTOs.Book
{
    public record UpdateBookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
    }
}
