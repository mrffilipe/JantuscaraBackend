using Jantuscara.Application.Common;
using Jantuscara.Application.Interfaces.UseCases.Restaurant;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Restaurant
{
    public class DeleteRestaurantUseCase : IDeleteRestaurantUseCase
    {
        private readonly IRestaurantRepository _repository;

        public DeleteRestaurantUseCase(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetRestaurantByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Restaurante não encontrado.");
            }

            _repository.DeleteRestaurantAsync(result);
            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Restaurante '{result.Name}' deletado com sucesso!"
            };
        }
    }
}
