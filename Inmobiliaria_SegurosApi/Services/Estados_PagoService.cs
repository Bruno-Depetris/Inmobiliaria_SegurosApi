using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Estados_PagoService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Estados_PagoService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estados_Pago>> GetAllAsync()
        {
            return await _context.Estados_Pago.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Estados_Pago.FindAsync(id);
        }

        public async Task<Estados_Pago> CreateAsync(Estados_Pago entity)
        {
            _context.Estados_Pago.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Estados_Pago entity)
        {
            _context.Estados_Pago.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estados_Pago entity)
        {
            _context.Estados_Pago.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































