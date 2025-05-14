using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IAddTasterUseCase
    {
        Task<IMessageResponse> ExecuteAsync(AddTasterDto dto);
    }
}