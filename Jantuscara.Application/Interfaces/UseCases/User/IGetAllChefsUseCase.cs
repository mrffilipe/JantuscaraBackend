using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IGetAllChefsUseCase
    {
        Task<IEnumerable<ChefDto>> ExecuteAsync();
    }
}