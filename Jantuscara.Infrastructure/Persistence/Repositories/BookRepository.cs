using Jantuscara.Domain.Entities;
using Jantuscara.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Jantuscara.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddBookAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task<Book?> GetBookByIdAsync(Guid bookId)
        {
            return await _context.Books
                .FirstOrDefaultAsync(b => b.Id == bookId);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public void DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
