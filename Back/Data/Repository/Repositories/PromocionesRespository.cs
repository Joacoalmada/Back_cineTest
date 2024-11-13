using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Back.Data.Repository.Repositories
{
    public class PromocionesRespository : IPromocionesRespository
    {
        private readonly CineDBContext _context;

        public PromocionesRespository(CineDBContext context) 
        {
            _context = context;
        }
        public async Task<List<Promocione>> GetAll()
        {
            return await _context.Promociones.ToListAsync();
        }
    }
}
