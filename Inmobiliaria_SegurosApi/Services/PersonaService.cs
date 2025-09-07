using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class PersonaService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public PersonaService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Persona>> GetAllAsync()
        {
            return await _context.Persona.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Persona.FindAsync(id);
        }

        public async Task<Persona> CreateAsync(Persona entity)
        {
            _context.Persona.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Persona entity)
        {
            _context.Persona.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Persona entity)
        {
            _context.Persona.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































