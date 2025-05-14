using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(Category category);
        Task<Category?> GetCategoryByIdAsync(Guid categoryId);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        void DeleteCategoryAsync(Category category);
        Task SaveChangesAsync();
    }
}
