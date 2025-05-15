using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class UpdateEditorUseCase : IUpdateEditorUseCase
    {
        private readonly IUserRepository _repository;

        public UpdateEditorUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(UpdateEditorDto dto)
        {
            var result = await _repository.GetEditorByIdAsync(dto.Id);

            if (result == null)
            {
                throw new Exception("Editor não encontrado.");
            }

            result.UpdateInfo(dto.Name, dto.ContractDate);

            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Editor '{dto.Name}' atualizado com sucesso!"
            };
        }
    }
}
