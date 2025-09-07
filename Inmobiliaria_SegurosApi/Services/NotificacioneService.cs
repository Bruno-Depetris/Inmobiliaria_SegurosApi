using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class NotificacioneService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public NotificacioneService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Notificacione>> GetAllAsync()
        {
            return await _context.Notificacione.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Notificacione.FindAsync(id);
        }

        public async Task<Notificacione> CreateAsync(Notificacione entity)
        {
            _context.Notificacione.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Notificacione entity)
        {
            _context.Notificacione.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Notificacione entity)
        {
            _context.Notificacione.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































