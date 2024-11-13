using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Back.Data.Repository.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        private CineDBContext _context;

        public SalaRepository(CineDBContext context) 
        {
            _context = context;
        }

        public async Task<List<Sala>> GetAll()
        {
            return await _context.Salas.ToListAsync();
        }
    }
}
