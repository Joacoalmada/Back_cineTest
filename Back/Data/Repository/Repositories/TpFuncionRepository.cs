using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Back.Data.Repository.Repositories
{
    public class TpFuncionRepository : ITpFuncionRepository
    {
        private readonly CineDBContext _context;

        public TpFuncionRepository(CineDBContext context)
        {
            _context = context;
        }

        public async Task<List<TiposFuncion>> GetAll()
        {
            return await _context.TiposFuncions.ToListAsync();
        }
    }
}
