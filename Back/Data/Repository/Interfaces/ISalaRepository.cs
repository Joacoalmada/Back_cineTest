using Back.Data.Models;

namespace Back.Data.Repository.Interfaces
{
    public interface ISalaRepository
    {
        Task<List<Sala>> GetAll();
    }
}
