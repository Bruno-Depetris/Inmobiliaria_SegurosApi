using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Sesiones_JWTService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Sesiones_JWTService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Sesiones_JWT>> GetAllAsync()
        {
            return await _context.Sesiones_JWT.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Sesiones_JWT.FindAsync(id);
        }

        public async Task<Sesiones_JWT> CreateAsync(Sesiones_JWT entity)
        {
            _context.Sesiones_JWT.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Sesiones_JWT entity)
        {
            _context.Sesiones_JWT.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Sesiones_JWT entity)
        {
            _context.Sesiones_JWT.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































