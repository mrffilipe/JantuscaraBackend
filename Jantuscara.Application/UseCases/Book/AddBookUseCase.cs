using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Book;
using Jantuscara.Application.Interfaces.UseCases.Book;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Book
{
    public class AddBookUseCase : IAddBookUseCase
    {
        private readonly IBookRepository _repository;

        public AddBookUseCase(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(AddBookDto dto)
        {
            var newBook = new Domain.Entities.Book(dto.Title, dto.ISBN, dto.EditorId);

            await _repository.AddBookAsync(newBook);

            return new MessageResponse
            {
                Message = $"Livro '{dto.Title}' criado com sucesso!"
            };
        }
    }
}
