using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IGetTasterByIdUseCase
    {
        Task<TasterDto?> ExecuteAsync(Guid id);
    }
}