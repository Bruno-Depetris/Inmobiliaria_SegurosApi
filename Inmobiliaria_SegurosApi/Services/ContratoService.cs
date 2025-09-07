using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class ContratoService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public ContratoService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contrato>> GetAllAsync()
        {
            return await _context.Contrato.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Contrato.FindAsync(id);
        }

        public async Task<Contrato> CreateAsync(Contrato entity)
        {
            _context.Contrato.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Contrato entity)
        {
            _context.Contrato.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Contrato entity)
        {
            _context.Contrato.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































