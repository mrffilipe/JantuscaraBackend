using Jantuscara.Application.Common;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IDeleteChefUseCase
    {
        Task<IMessageResponse> ExecuteAsync(Guid id);
    }
}