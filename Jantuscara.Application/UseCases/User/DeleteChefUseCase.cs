using Jantuscara.Application.Common;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class DeleteChefUseCase : IDeleteChefUseCase
    {
        private readonly IUserRepository _repository;

        public DeleteChefUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetCheftByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Cozinheiro não encontrado.");
            }

            _repository.DeleteChefAsync(result);
            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Cozinheiro '{result.Name}' deletado com sucesso!"
            };
        }
    }
}
