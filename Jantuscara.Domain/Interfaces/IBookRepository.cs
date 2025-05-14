using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IBookRepository
    {
        Task AddBookAsync(Book book);
        Task<Book?> GetBookByIdAsync(Guid bookId);
        Task<IEnumerable<Book>> GetAllBooksAsync();
        void DeleteBookAsync(Book book);
        Task SaveChangesAsync();
    }
}
