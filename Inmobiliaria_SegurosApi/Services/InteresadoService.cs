using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class InteresadoService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public InteresadoService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Interesado>> GetAllAsync()
        {
            return await _context.Interesado.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Interesado.FindAsync(id);
        }

        public async Task<Interesado> CreateAsync(Interesado entity)
        {
            _context.Interesado.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Interesado entity)
        {
            _context.Interesado.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Interesado entity)
        {
            _context.Interesado.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































