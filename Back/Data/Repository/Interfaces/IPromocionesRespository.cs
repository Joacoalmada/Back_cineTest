using Back.Data.Models;

namespace Back.Data.Repository.Interfaces
{
    public interface IPromocionesRespository
    {
        Task<List<Promocione>> GetAll();
    }
}
