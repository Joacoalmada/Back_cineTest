using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Back.Data.Repository.Repositories
{
    public class IdiomaRepository : IDiomaRepository
    {
        private readonly CineDBContext _context;

        public IdiomaRepository(CineDBContext context) 
        {
            _context = context;
        }
        public async Task<List<Idioma>> GetAll()
        {
            return await _context.Idiomas.ToListAsync();
        }
    }
}
