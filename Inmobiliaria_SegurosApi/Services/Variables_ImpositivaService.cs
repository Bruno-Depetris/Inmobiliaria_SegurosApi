using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Variables_ImpositivaService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Variables_ImpositivaService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Variables_Impositiva>> GetAllAsync()
        {
            return await _context.Variables_Impositiva.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Variables_Impositiva.FindAsync(id);
        }

        public async Task<Variables_Impositiva> CreateAsync(Variables_Impositiva entity)
        {
            _context.Variables_Impositiva.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Variables_Impositiva entity)
        {
            _context.Variables_Impositiva.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Variables_Impositiva entity)
        {
            _context.Variables_Impositiva.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































