using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IGetAllEditorsUseCase
    {
        Task<IEnumerable<EditorDto>> ExecuteAsync();
    }
}