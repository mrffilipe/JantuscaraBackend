using Jantuscara.Application.Common;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class DeleteEditorUseCase : IDeleteEditorUseCase
    {
        private readonly IUserRepository _repository;

        public DeleteEditorUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetEditorByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Editor não encontrado.");
            }

            _repository.DeleteEditorAsync(result);
            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Editor '{result.Name}' deletado com sucesso!"
            };
        }
    }
}
