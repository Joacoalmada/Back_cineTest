using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface IPeliculaService
    {
        Task<List<PeliculaDto>> ObtenerPeliculas();
        Task<PeliculaDto>? ObtenerPeliculaPorId(int id);
        Task<bool> GuardarPelicula(Pelicula p);
        Task<bool> EliminarPelicula(int id);
        Task<PeliculaDto>? ObtenerPeliculaPorTitulo(string titulo);
    }
}
