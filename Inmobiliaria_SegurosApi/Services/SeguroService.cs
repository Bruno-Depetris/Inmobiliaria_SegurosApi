using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class SeguroService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public SeguroService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Seguro>> GetAllAsync()
        {
            return await _context.Seguro.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Seguro.FindAsync(id);
        }

        public async Task<Seguro> CreateAsync(Seguro entity)
        {
            _context.Seguro.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Seguro entity)
        {
            _context.Seguro.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Seguro entity)
        {
            _context.Seguro.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































