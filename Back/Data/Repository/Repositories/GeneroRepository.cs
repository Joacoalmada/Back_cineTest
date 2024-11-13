using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Back.Data.Repository.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly CineDBContext _context;

        public GeneroRepository(CineDBContext context) 
        {
            _context = context;
        }
        public async Task<List<Genero>> GetAll()
        {
            return await _context.Generos.ToListAsync();
        }
    }
}
