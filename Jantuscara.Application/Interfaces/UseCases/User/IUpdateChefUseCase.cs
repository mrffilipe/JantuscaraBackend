using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IUpdateChefUseCase
    {
        Task<IMessageResponse> ExecuteAsync(UpdateChefDto dto);
    }
}