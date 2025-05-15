using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Entities;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class AddTasterUseCase : IAddTasterUseCase
    {
        private readonly IUserRepository _repository;

        public AddTasterUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(AddTasterDto dto)
        {
            var newTaster = new Taster(dto.Name, dto.ContractDate);

            await _repository.AddTasterAsync(newTaster);

            return new MessageResponse
            {
                Message = $"Desgustador '{dto.Name}' criado com sucesso!"
            };
        }
    }
}
