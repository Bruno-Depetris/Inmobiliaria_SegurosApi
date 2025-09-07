using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Roles_UsuarioService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Roles_UsuarioService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Roles_Usuario>> GetAllAsync()
        {
            return await _context.Roles_Usuario.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Roles_Usuario.FindAsync(id);
        }

        public async Task<Roles_Usuario> CreateAsync(Roles_Usuario entity)
        {
            _context.Roles_Usuario.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Roles_Usuario entity)
        {
            _context.Roles_Usuario.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Roles_Usuario entity)
        {
            _context.Roles_Usuario.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































