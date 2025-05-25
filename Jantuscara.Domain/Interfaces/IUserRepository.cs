using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task AddChefAsync(Chef chef);
        Task<Chef?> GetCheftByIdAsync(Guid chefId);
        Task<IEnumerable<Chef>> GetAllChefsAsync();
        Task<IEnumerable<Chef>> GetAllChefsByYearAsync(int year);
        void DeleteChefAsync(Chef chef);

        Task AddTasterAsync(Taster taster);
        Task<Taster?> GetTasterByIdAsync(Guid tasterId);
        Task<IEnumerable<Taster>> GetAllTastersAsync();
        void DeleteTasterAsync(Taster taster);

        Task AddEditorAsync(Editor editor);
        Task<Editor?> GetEditorByIdAsync(Guid editorId);
        Task<IEnumerable<Editor>> GetAllEditorsAsync();
        void DeleteEditorAsync(Editor editor);

        Task SaveChangesAsync();
    }
}
