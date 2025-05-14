using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Book;

namespace Jantuscara.Application.Interfaces.UseCases.Book
{
    public interface IAddBookUseCase
    {
        Task<IMessageResponse> ExecuteAsync(AddBookDto dto);
    }
}
