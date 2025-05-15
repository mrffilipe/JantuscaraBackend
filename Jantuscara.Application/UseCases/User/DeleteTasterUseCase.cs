using Jantuscara.Application.Common;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class DeleteTasterUseCase : IDeleteTasterUseCase
    {
        private readonly IUserRepository _repository;

        public DeleteTasterUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetTasterByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Degustador não encontrado.");
            }

            _repository.DeleteTasterAsync(result);
            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Degustador '{result.Name}' deletado com sucesso!"
            };
        }
    }
}
