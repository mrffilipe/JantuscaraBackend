using Jantuscara.Application.DTOs.Restaurant;
using Jantuscara.Application.Interfaces.UseCases.Restaurant;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Restaurant
{
    public class GetAllRestaurantsUseCase : IGetAllRestaurantsUseCase
    {
        private readonly IRestaurantRepository _repository;

        public GetAllRestaurantsUseCase(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<RestaurantDto>> ExecuteAsync()
        {
            var result = await _repository.GetAllRestaurantsAsync();

            return result.Select(r => new RestaurantDto
            {
                Id = r.Id,
                Name = r.Name,
                Resume = r.Resume
            });
        }
    }
}
