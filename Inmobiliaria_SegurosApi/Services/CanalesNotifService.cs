using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class CanalesNotifService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public CanalesNotifService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<CanalesNotif>> GetAllAsync()
        {
            return await _context.CanalesNotif.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.CanalesNotif.FindAsync(id);
        }

        public async Task<CanalesNotif> CreateAsync(CanalesNotif entity)
        {
            _context.CanalesNotif.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(CanalesNotif entity)
        {
            _context.CanalesNotif.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CanalesNotif entity)
        {
            _context.CanalesNotif.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































