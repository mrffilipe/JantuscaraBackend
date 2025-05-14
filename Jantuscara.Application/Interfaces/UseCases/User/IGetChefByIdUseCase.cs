using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IGetChefByIdUseCase
    {
        Task<ChefDto?> ExecuteAsync(Guid id);
    }
}