using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface ISalaService
    {
        Task<List<Sala>> ObtenerSalas();
    }
}
