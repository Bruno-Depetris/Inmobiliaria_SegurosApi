using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Services
{
    public class Tipos_DocumentoService
    {
        private readonly InmobiliariaSegurosDbContext _context;

 

































       public Tipos_DocumentoService(InmobiliariaSegurosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tipos_Documento>> GetAllAsync()
        {
            return await _context.Tipos_Documento.ToListAsync();
        }

        public async Task<> GetByIdAsync(int id)
        {
            return await _context.Tipos_Documento.FindAsync(id);
        }

        public async Task<Tipos_Documento> CreateAsync(Tipos_Documento entity)
        {
            _context.Tipos_Documento.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Tipos_Documento entity)
        {
            _context.Tipos_Documento.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tipos_Documento entity)
        {
            _context.Tipos_Documento.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}


































