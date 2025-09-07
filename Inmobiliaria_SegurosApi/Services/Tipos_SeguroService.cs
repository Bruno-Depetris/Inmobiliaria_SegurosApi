using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Tipos_SeguroService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Tipos_SeguroService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tipos_Seguro>> GetAllAsync()
        {
            return await _context.Tipos_Seguro.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Tipos_Seguro.FindAsync(id);
        }

        public async Task<Tipos_Seguro> CreateAsync(Tipos_Seguro entity)
        {
            _context.Tipos_Seguro.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Tipos_Seguro entity)
        {
            _context.Tipos_Seguro.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tipos_Seguro entity)
        {
            _context.Tipos_Seguro.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































