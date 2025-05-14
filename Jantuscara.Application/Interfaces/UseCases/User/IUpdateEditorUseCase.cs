using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IUpdateEditorUseCase
    {
        Task<IMessageResponse> ExecuteAsync(UpdateEditorDto dto);
    }
}