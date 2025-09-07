using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class ComisionesService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public ComisionesService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Comisiones>> GetAllAsync()
        {
            return await _context.Comisiones.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Comisiones.FindAsync(id);
        }

        public async Task<Comisiones> CreateAsync(Comisiones entity)
        {
            _context.Comisiones.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Comisiones entity)
        {
            _context.Comisiones.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Comisiones entity)
        {
            _context.Comisiones.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































