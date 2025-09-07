using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class CiudadeService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public CiudadeService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ciudade>> GetAllAsync()
        {
            return await _context.Ciudade.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Ciudade.FindAsync(id);
        }

        public async Task<Ciudade> CreateAsync(Ciudade entity)
        {
            _context.Ciudade.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Ciudade entity)
        {
            _context.Ciudade.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Ciudade entity)
        {
            _context.Ciudade.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































