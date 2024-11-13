using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Back.Data.Repository.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly CineDBContext _context;

        public DirectorRepository(CineDBContext context)
        {
            _context = context;
        }

        public async Task<List<Directore>> GetAll()
        {
            return await _context.Directores.ToListAsync();
        }
    }
}
