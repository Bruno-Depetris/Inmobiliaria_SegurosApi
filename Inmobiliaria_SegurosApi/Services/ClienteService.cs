using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class ClienteService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public ClienteService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> GetAllAsync()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Cliente.FindAsync(id);
        }

        public async Task<Cliente> CreateAsync(Cliente entity)
        {
            _context.Cliente.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Cliente entity)
        {
            _context.Cliente.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Cliente entity)
        {
            _context.Cliente.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































