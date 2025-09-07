using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Fotos_PropiedadeService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Fotos_PropiedadeService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Fotos_Propiedade>> GetAllAsync()
        {
            return await _context.Fotos_Propiedade.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Fotos_Propiedade.FindAsync(id);
        }

        public async Task<Fotos_Propiedade> CreateAsync(Fotos_Propiedade entity)
        {
            _context.Fotos_Propiedade.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Fotos_Propiedade entity)
        {
            _context.Fotos_Propiedade.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Fotos_Propiedade entity)
        {
            _context.Fotos_Propiedade.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































