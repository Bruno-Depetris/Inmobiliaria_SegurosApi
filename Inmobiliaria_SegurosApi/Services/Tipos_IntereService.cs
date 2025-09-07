using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Tipos_IntereService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Tipos_IntereService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tipos_Intere>> GetAllAsync()
        {
            return await _context.Tipos_Intere.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Tipos_Intere.FindAsync(id);
        }

        public async Task<Tipos_Intere> CreateAsync(Tipos_Intere entity)
        {
            _context.Tipos_Intere.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Tipos_Intere entity)
        {
            _context.Tipos_Intere.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tipos_Intere entity)
        {
            _context.Tipos_Intere.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































