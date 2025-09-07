using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Roles_ClienteService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Roles_ClienteService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Roles_Cliente>> GetAllAsync()
        {
            return await _context.Roles_Cliente.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Roles_Cliente.FindAsync(id);
        }

        public async Task<Roles_Cliente> CreateAsync(Roles_Cliente entity)
        {
            _context.Roles_Cliente.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Roles_Cliente entity)
        {
            _context.Roles_Cliente.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Roles_Cliente entity)
        {
            _context.Roles_Cliente.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































