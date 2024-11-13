using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface IDirectorService
    {
        Task<List<Directore>> ObtenerDirectores();
    }
}
