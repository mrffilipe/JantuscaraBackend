using Jantuscara.Application.Common;
using Jantuscara.Application.Interfaces.UseCases.Book;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Book
{
    public class DeleteBookUseCase : IDeleteBookUseCase
    {
        private readonly IBookRepository _repository;

        public DeleteBookUseCase(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetBookByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Livro não encontrado.");
            }

            _repository.DeleteBookAsync(result);
            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Livro '{result.Title}' deletado com sucesso!"
            };
        }
    }
}
