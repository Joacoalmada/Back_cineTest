using Back.Data.Models;

namespace Back.Data.Repository.Interfaces
{
    public interface IGeneroRepository
    {
        Task<List<Genero>> GetAll();
    }
}
