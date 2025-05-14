using Jantuscara.Application.Common;

namespace Jantuscara.Application.Interfaces.UseCases.Book
{
    public interface IDeleteBookUseCase
    {
        Task<IMessageResponse> ExecuteAsync(Guid id);
    }
}
