using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Estados_CivilService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Estados_CivilService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estados_Civil>> GetAllAsync()
        {
            return await _context.Estados_Civil.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Estados_Civil.FindAsync(id);
        }

        public async Task<Estados_Civil> CreateAsync(Estados_Civil entity)
        {
            _context.Estados_Civil.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Estados_Civil entity)
        {
            _context.Estados_Civil.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estados_Civil entity)
        {
            _context.Estados_Civil.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































