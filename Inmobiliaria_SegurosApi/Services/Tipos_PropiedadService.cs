using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Tipos_PropiedadService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Tipos_PropiedadService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tipos_Propiedad>> GetAllAsync()
        {
            return await _context.Tipos_Propiedad.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Tipos_Propiedad.FindAsync(id);
        }

        public async Task<Tipos_Propiedad> CreateAsync(Tipos_Propiedad entity)
        {
            _context.Tipos_Propiedad.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Tipos_Propiedad entity)
        {
            _context.Tipos_Propiedad.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tipos_Propiedad entity)
        {
            _context.Tipos_Propiedad.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































