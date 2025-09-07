using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Estados_ContratoService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Estados_ContratoService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estados_Contrato>> GetAllAsync()
        {
            return await _context.Estados_Contrato.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Estados_Contrato.FindAsync(id);
        }

        public async Task<Estados_Contrato> CreateAsync(Estados_Contrato entity)
        {
            _context.Estados_Contrato.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Estados_Contrato entity)
        {
            _context.Estados_Contrato.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estados_Contrato entity)
        {
            _context.Estados_Contrato.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































