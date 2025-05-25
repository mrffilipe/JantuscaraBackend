using Jantuscara.Domain.Entities;
using Jantuscara.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Jantuscara.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddChefAsync(Chef chef)
        {
            await _context.Chefs.AddAsync(chef);
            await _context.SaveChangesAsync();
        }

        public async Task<Chef?> GetCheftByIdAsync(Guid chefId)
        {
            return await _context.Chefs
                .FirstOrDefaultAsync(c => c.Id == chefId);
        }

        public async Task<IEnumerable<Chef>> GetAllChefsAsync()
        {
            return await _context.Chefs.ToListAsync();
        }

        public async Task<IEnumerable<Chef>> GetAllChefsByYearAsync(int year)
        {
            return await _context.Chefs
                .Where(c => c.ContractDate.ToDateTime(TimeOnly.MinValue).Year == year)
                .Include(c => c.Recipes)
                .ToListAsync();
        }

        public void DeleteChefAsync(Chef chef)
        {
            _context.Chefs.Remove(chef);
        }

        public async Task AddTasterAsync(Taster taster)
        {
            await _context.Tasters.AddAsync(taster);
            await _context.SaveChangesAsync();
        }

        public async Task<Taster?> GetTasterByIdAsync(Guid tasterId)
        {
            return await _context.Tasters
                .FirstOrDefaultAsync(t => t.Id == tasterId);
        }

        public async Task<IEnumerable<Taster>> GetAllTastersAsync()
        {
            return await _context.Tasters.ToListAsync();
        }

        public void DeleteTasterAsync(Taster taster)
        {
            _context.Tasters.Remove(taster);
        }

        public async Task AddEditorAsync(Editor editor)
        {
            await _context.Editors.AddAsync(editor);
            await _context.SaveChangesAsync();
        }

        public async Task<Editor?> GetEditorByIdAsync(Guid editorId)
        {
            return await _context.Editors
                .FirstOrDefaultAsync(e => e.Id == editorId);
        }

        public async Task<IEnumerable<Editor>> GetAllEditorsAsync()
        {
            return await _context.Editors.ToListAsync();
        }

        public void DeleteEditorAsync(Editor editor)
        {
            _context.Editors.Remove(editor);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
