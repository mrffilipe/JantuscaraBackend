using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IGetEditorByIdUseCase
    {
        Task<EditorDto?> ExecuteAsync(Guid id);
    }
}