using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Restaurant;
using Jantuscara.Application.Interfaces.UseCases.Restaurant;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Restaurant
{
    public class AddRestaurantUseCase : IAddRestaurantUseCase
    {
        private readonly IRestaurantRepository _repository;

        public AddRestaurantUseCase(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(AddRestaurantDto dto)
        {
            var newRestaurant = new Domain.Entities.Restaurant(dto.Name, dto.Resume);

            await _repository.AddRestaurantAsync(newRestaurant);

            return new MessageResponse
            {
                Message = $"Restaurante '{dto.Name}' criado com sucesso!"
            };
        }
    }
}
