using Jantuscara.Application.DTOs.Restaurant;
using Jantuscara.Application.Interfaces.UseCases.Restaurant;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Restaurant
{
    public class GetRestaurantByIdUseCase : IGetRestaurantByIdUseCase
    {
        private readonly IRestaurantRepository _repository;

        public GetRestaurantByIdUseCase(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public async Task<RestaurantDto?> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetRestaurantByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Restaurante não encontrado.");
            }

            return new RestaurantDto
            {
                Id = result.Id,
                Name = result.Name,
                Resume = result.Resume
            };
        }
    }
}
