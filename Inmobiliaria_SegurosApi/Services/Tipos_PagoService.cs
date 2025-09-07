using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Tipos_PagoService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Tipos_PagoService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tipos_Pago>> GetAllAsync()
        {
            return await _context.Tipos_Pago.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Tipos_Pago.FindAsync(id);
        }

        public async Task<Tipos_Pago> CreateAsync(Tipos_Pago entity)
        {
            _context.Tipos_Pago.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Tipos_Pago entity)
        {
            _context.Tipos_Pago.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tipos_Pago entity)
        {
            _context.Tipos_Pago.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































