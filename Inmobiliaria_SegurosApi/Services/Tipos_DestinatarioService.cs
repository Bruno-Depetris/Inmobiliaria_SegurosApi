using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Tipos_DestinatarioService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Tipos_DestinatarioService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tipos_Destinatario>> GetAllAsync()
        {
            return await _context.Tipos_Destinatario.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Tipos_Destinatario.FindAsync(id);
        }

        public async Task<Tipos_Destinatario> CreateAsync(Tipos_Destinatario entity)
        {
            _context.Tipos_Destinatario.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Tipos_Destinatario entity)
        {
            _context.Tipos_Destinatario.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tipos_Destinatario entity)
        {
            _context.Tipos_Destinatario.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































