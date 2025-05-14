using Jantuscara.Application.Common;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IDeleteEditorUseCase
    {
        Task<IMessageResponse> ExecuteAsync(Guid id);
    }
}