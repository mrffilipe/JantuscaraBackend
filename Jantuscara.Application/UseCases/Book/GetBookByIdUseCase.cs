using Jantuscara.Application.DTOs.Book;
using Jantuscara.Application.DTOs.Restaurant;
using Jantuscara.Application.Interfaces.UseCases.Book;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Book
{
    public class GetBookByIdUseCase : IGetBookByIdUseCase
    {
        private readonly IBookRepository _repository;

        public GetBookByIdUseCase(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<BookDto?> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetBookByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Livro não encontrado.");
            }

            return new BookDto
            {
                Id = result.Id,
                Title = result.Title,
                ISBN = result.ISBN,
                EditorId = result.EditorId
            };
        }
    }
}
