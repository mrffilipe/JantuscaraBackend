using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class UpdateTasterUseCase : IUpdateTasterUseCase
    {
        private readonly IUserRepository _repository;

        public UpdateTasterUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(UpdateTasterDto dto)
        {
            var result = await _repository.GetTasterByIdAsync(dto.Id);

            if (result == null)
            {
                throw new Exception("Degustador não encontrado.");
            }

            result.UpdateInfo(dto.Name, dto.ContractDate);

            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Degustador '{dto.Name}' atualizado com sucesso!"
            };
        }
    }
}
