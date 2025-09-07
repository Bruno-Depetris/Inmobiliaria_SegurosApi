using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class UsuarioService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public UsuarioService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return await _context.Usuario.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Usuario.FindAsync(id);
        }

        public async Task<Usuario> CreateAsync(Usuario entity)
        {
            _context.Usuario.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Usuario entity)
        {
            _context.Usuario.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Usuario entity)
        {
            _context.Usuario.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































