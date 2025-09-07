using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Estados_SeguroService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Estados_SeguroService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estados_Seguro>> GetAllAsync()
        {
            return await _context.Estados_Seguro.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Estados_Seguro.FindAsync(id);
        }

        public async Task<Estados_Seguro> CreateAsync(Estados_Seguro entity)
        {
            _context.Estados_Seguro.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Estados_Seguro entity)
        {
            _context.Estados_Seguro.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estados_Seguro entity)
        {
            _context.Estados_Seguro.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































