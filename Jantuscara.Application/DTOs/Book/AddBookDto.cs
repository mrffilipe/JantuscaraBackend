namespace Jantuscara.Application.DTOs.Book
{
    public record AddBookDto
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public Guid EditorId { get; set; }
    }
}
