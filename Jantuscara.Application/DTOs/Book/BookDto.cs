using Jantuscara.Application.Common;

namespace Jantuscara.Application.DTOs.Book
{
    public record BookDto : IMessageResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public Guid EditorId { get; set; }

        public string Message => $"Livro '{Title}' listado com sucesso!";
    }
}
