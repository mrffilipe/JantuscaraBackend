using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Restaurant;
using Jantuscara.Application.Interfaces.UseCases.Restaurant;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Restaurant
{
    public class UpdateRestaurantUseCase : IUpdateRestaurantUseCase
    {
        private readonly IRestaurantRepository _repository;

        public UpdateRestaurantUseCase(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(UpdateRestaurantDto dto)
        {
            var result = await _repository.GetRestaurantByIdAsync(dto.Id);

            if (result == null)
            {
                throw new Exception("Restaurante não encontrado.");
            }

            result.UpdateInfo(dto.Name, dto.Resume);

            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Restaurante '{dto.Name}' atualizado com sucesso!"
            };
        }
    }
}
