using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface IIdiomaService
    {
        Task<List<Idioma>> ObtenerIdiomas();
    }
}
