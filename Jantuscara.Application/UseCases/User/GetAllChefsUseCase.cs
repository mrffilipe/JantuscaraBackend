using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class GetAllChefsUseCase : IGetAllChefsUseCase
    {
        private readonly IUserRepository _repository;

        public GetAllChefsUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ChefDto>> ExecuteAsync()
        {
            var result = await _repository.GetAllChefsAsync();

            return result.Select(r => new ChefDto
            {
                Id = r.Id,
                Name = r.Name,
                ContractDate = r.ContractDate,
                TradeName = r.TradeName,
                RestaurantId = r.RestaurantId
            });
        }
    }
}
