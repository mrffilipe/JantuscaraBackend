using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Entities;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class AddChefUseCase : IAddChefUseCase
    {
        private readonly IUserRepository _repository;

        public AddChefUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(AddChefDto dto)
        {
            var newCheft = new Chef(dto.Name, dto.ContractDate, dto.TradeName, dto.RestaurantId);

            await _repository.AddChefAsync(newCheft);

            return new MessageResponse
            {
                Message = $"Cozinheiro '{dto.Name}' criado com sucesso!"
            };
        }
    }
}
