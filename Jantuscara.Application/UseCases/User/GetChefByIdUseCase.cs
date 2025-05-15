using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class GetChefByIdUseCase : IGetChefByIdUseCase
    {
        private readonly IUserRepository _repository;

        public GetChefByIdUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<ChefDto?> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetCheftByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Cozinheiro não encontrado.");
            }

            return new ChefDto
            {
                Id = result.Id,
                Name = result.Name,
                ContractDate = result.ContractDate,
                TradeName = result.TradeName,
                RestaurantId = result.RestaurantId
            };
        }
    }
}
