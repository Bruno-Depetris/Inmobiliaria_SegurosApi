using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Estados_UsuarioService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Estados_UsuarioService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estados_Usuario>> GetAllAsync()
        {
            return await _context.Estados_Usuario.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Estados_Usuario.FindAsync(id);
        }

        public async Task<Estados_Usuario> CreateAsync(Estados_Usuario entity)
        {
            _context.Estados_Usuario.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Estados_Usuario entity)
        {
            _context.Estados_Usuario.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estados_Usuario entity)
        {
            _context.Estados_Usuario.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































