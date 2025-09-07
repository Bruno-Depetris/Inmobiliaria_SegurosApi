using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class ProductoreService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public ProductoreService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Productore>> GetAllAsync()
        {
            return await _context.Productore.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Productore.FindAsync(id);
        }

        public async Task<Productore> CreateAsync(Productore entity)
        {
            _context.Productore.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Productore entity)
        {
            _context.Productore.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Productore entity)
        {
            _context.Productore.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































