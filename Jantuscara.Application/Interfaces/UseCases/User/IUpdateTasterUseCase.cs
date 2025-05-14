using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IUpdateTasterUseCase
    {
        Task<IMessageResponse> ExecuteAsync(UpdateTasterDto dto);
    }
}