using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Metodos_PagoService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Metodos_PagoService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Metodos_Pago>> GetAllAsync()
        {
            return await _context.Metodos_Pago.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Metodos_Pago.FindAsync(id);
        }

        public async Task<Metodos_Pago> CreateAsync(Metodos_Pago entity)
        {
            _context.Metodos_Pago.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Metodos_Pago entity)
        {
            _context.Metodos_Pago.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Metodos_Pago entity)
        {
            _context.Metodos_Pago.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































