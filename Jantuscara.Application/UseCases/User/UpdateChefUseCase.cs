using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class UpdateChefUseCase : IUpdateChefUseCase
    {
        private readonly IUserRepository _repository;

        public UpdateChefUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(UpdateChefDto dto)
        {
            var result = await _repository.GetCheftByIdAsync(dto.Id);

            if (result == null)
            {
                throw new Exception("Cozinheiro não encontrado.");
            }

            result.UpdateTradeName(dto.TradeName);
            result.UpdateInfo(dto.Name, dto.ContractDate);

            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Cozinheiro '{dto.Name}' atualizado com sucesso!"
            };
        }
    }
}
