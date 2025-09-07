using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Estados_PropiedadService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Estados_PropiedadService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estados_Propiedad>> GetAllAsync()
        {
            return await _context.Estados_Propiedad.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Estados_Propiedad.FindAsync(id);
        }

        public async Task<Estados_Propiedad> CreateAsync(Estados_Propiedad entity)
        {
            _context.Estados_Propiedad.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Estados_Propiedad entity)
        {
            _context.Estados_Propiedad.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estados_Propiedad entity)
        {
            _context.Estados_Propiedad.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































