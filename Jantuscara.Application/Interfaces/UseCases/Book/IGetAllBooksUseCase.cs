using Jantuscara.Application.DTOs.Book;

namespace Jantuscara.Application.Interfaces.UseCases.Book
{
    public interface IGetAllBooksUseCase
    {
        Task<IEnumerable<BookDto>> ExecuteAsync();
    }
}
