using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class PagoService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public PagoService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pago>> GetAllAsync()
        {
            return await _context.Pago.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Pago.FindAsync(id);
        }

        public async Task<Pago> CreateAsync(Pago entity)
        {
            _context.Pago.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Pago entity)
        {
            _context.Pago.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Pago entity)
        {
            _context.Pago.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































