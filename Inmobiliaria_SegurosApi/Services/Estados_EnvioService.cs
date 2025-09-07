using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Estados_EnvioService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Estados_EnvioService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estados_Envio>> GetAllAsync()
        {
            return await _context.Estados_Envio.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Estados_Envio.FindAsync(id);
        }

        public async Task<Estados_Envio> CreateAsync(Estados_Envio entity)
        {
            _context.Estados_Envio.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Estados_Envio entity)
        {
            _context.Estados_Envio.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estados_Envio entity)
        {
            _context.Estados_Envio.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































