using Jantuscara.Application.Common;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IDeleteTasterUseCase
    {
        Task<IMessageResponse> ExecuteAsync(Guid id);
    }
}