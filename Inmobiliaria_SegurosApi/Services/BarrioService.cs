using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class BarrioService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public BarrioService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Barrio>> GetAllAsync()
        {
            return await _context.Barrio.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Barrio.FindAsync(id);
        }

        public async Task<Barrio> CreateAsync(Barrio entity)
        {
            _context.Barrio.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Barrio entity)
        {
            _context.Barrio.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Barrio entity)
        {
            _context.Barrio.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































