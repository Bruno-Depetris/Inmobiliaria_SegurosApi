using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class MonedaService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public MonedaService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Moneda>> GetAllAsync()
        {
            return await _context.Moneda.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Moneda.FindAsync(id);
        }

        public async Task<Moneda> CreateAsync(Moneda entity)
        {
            _context.Moneda.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Moneda entity)
        {
            _context.Moneda.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Moneda entity)
        {
            _context.Moneda.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































