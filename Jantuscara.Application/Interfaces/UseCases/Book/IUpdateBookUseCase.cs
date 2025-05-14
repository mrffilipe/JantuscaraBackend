using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Book;

namespace Jantuscara.Application.Interfaces.UseCases.Book
{
    public interface IUpdateBookUseCase
    {
        Task<IMessageResponse> ExecuteAsync(UpdateBookDto dto);
    }
}
