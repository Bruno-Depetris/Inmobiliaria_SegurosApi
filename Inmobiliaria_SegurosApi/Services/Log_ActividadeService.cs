using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Log_ActividadeService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Log_ActividadeService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Log_Actividade>> GetAllAsync()
        {
            return await _context.Log_Actividade.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Log_Actividade.FindAsync(id);
        }

        public async Task<Log_Actividade> CreateAsync(Log_Actividade entity)
        {
            _context.Log_Actividade.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Log_Actividade entity)
        {
            _context.Log_Actividade.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Log_Actividade entity)
        {
            _context.Log_Actividade.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































