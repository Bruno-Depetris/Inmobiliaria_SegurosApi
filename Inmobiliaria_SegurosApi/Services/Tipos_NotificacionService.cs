using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Tipos_NotificacionService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Tipos_NotificacionService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tipos_Notificacion>> GetAllAsync()
        {
            return await _context.Tipos_Notificacion.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Tipos_Notificacion.FindAsync(id);
        }

        public async Task<Tipos_Notificacion> CreateAsync(Tipos_Notificacion entity)
        {
            _context.Tipos_Notificacion.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Tipos_Notificacion entity)
        {
            _context.Tipos_Notificacion.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tipos_Notificacion entity)
        {
            _context.Tipos_Notificacion.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































