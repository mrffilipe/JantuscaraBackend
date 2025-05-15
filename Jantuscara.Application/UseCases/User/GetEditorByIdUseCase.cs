using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class GetEditorByIdUseCase : IGetEditorByIdUseCase
    {
        private readonly IUserRepository _repository;

        public GetEditorByIdUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<EditorDto?> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetEditorByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Editor não encontrado.");
            }

            return new EditorDto
            {
                Id = result.Id,
                Name = result.Name,
                ContractDate = result.ContractDate
            };
        }
    }
}
