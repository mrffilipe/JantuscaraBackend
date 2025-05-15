using Jantuscara.Application.DTOs.Book;
using Jantuscara.Application.Interfaces.UseCases.Book;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Book
{
    public class GetAllBooksUseCase : IGetAllBooksUseCase
    {
        private readonly IBookRepository _repository;

        public GetAllBooksUseCase(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<BookDto>> ExecuteAsync()
        {
            var result = await _repository.GetAllBooksAsync();

            return result.Select(r => new BookDto
            {
                Id = r.Id,
                Title = r.Title,
                ISBN = r.ISBN,
                EditorId = r.EditorId
            });
        }
    }
}
