using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface IGeneroService
    {
        Task<List<Genero>> ObtenerGeneros();
    }
}
