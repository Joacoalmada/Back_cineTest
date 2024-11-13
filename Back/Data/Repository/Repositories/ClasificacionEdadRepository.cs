using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Back.Data.Repository.Repositories
{
    public class ClasificacionEdadRepository : IClasificacionEdad
    {
        private readonly CineDBContext _context;

        public ClasificacionEdadRepository(CineDBContext context) 
        {
            _context = context;
        }

        public async Task<List<ClasificacionesEdad>> GetAll()
        {
            return await _context.ClasificacionesEdads.ToListAsync();
        }
    }
}
