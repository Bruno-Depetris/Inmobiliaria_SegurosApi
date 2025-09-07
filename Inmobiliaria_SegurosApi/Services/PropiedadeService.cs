using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class PropiedadeService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public PropiedadeService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Propiedade>> GetAllAsync()
        {
            return await _context.Propiedade.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Propiedade.FindAsync(id);
        }

        public async Task<Propiedade> CreateAsync(Propiedade entity)
        {
            _context.Propiedade.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Propiedade entity)
        {
            _context.Propiedade.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Propiedade entity)
        {
            _context.Propiedade.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































