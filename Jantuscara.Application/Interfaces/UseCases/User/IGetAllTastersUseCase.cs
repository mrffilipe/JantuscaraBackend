using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IGetAllTastersUseCase
    {
        Task<IEnumerable<TasterDto>> ExecuteAsync();
    }
}