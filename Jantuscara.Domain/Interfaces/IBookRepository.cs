using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IBookRepository
    {
        Task<Book?> GetByIdAsync(Guid id);
        Task<Book?> GetByISBNAsync(string isbn);
        Task<IEnumerable<Book>> GetAllAsync();
        Task<IEnumerable<Book>> GetByEditorIdAsync(Guid editorId);

        Task<IEnumerable<Recipe>> GetRecipesByBookIdAsync(Guid bookId);
        Task<bool> IsRecipeAlreadyIncludedAsync(Guid bookId, Guid recipeId);

        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Guid id);

        Task<bool> ExistsByTitleAsync(string title);
    }
}
