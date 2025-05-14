using Jantuscara.Application.DTOs.Book;

namespace Jantuscara.Application.Interfaces.UseCases.Book
{
    public interface IGetBookByIdUseCase
    {
        Task<BookDto?> ExecuteAsync(Guid id);
    }
}
