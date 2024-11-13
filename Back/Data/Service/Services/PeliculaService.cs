using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;
using Back.Utilities;

namespace Back.Data.Service.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculasRepository _repository;
        private readonly IUtils _utils;

        public PeliculaService(IPeliculasRepository repository, IUtils utils)
        {
            _repository = repository;
            _utils = utils;
        }

        public Task<bool> EliminarPelicula(int id)
        {
            return _repository.DeleteById(id);
        }

        public Task<bool> GuardarPelicula(Pelicula p)
        {
            return _repository.Save(p);
        }

        public async Task<PeliculaDto>? ObtenerPeliculaPorId(int id)
        {
            var p = await _repository.GetById(id);

            var peliculaDto = new PeliculaDto()
            {
                CodPelicula = p.CodPelicula,
                Titulo = p.Titulo,
                FechaEstreno = p.FechaEstreno,
                DuracionMin = p.DuracionMin,
                Portada = p.Portada,
                Genero = _utils.GetGender(p.IdGenero.Value),
                ClasificacionEdad = _utils.GetClasification(p.IdClasificacion.Value),
                Director = _utils.GetDirector(p.IdDirector.Value),
                Idioma = _utils.GetLanguage(p.IdIdioma.Value),
            };

            return peliculaDto;

        }

        public async Task<PeliculaDto>? ObtenerPeliculaPorTitulo(string titulo)
        {
            var p = await _repository.GetByTitle(titulo);

            var peliculaDto = new PeliculaDto()
            {
                CodPelicula = p.CodPelicula,
                Titulo = p.Titulo,
                FechaEstreno = p.FechaEstreno,
                DuracionMin = p.DuracionMin,
                Portada = p.Portada,
                Genero = _utils.GetGender(p.IdGenero.Value),
                ClasificacionEdad = _utils.GetClasification(p.IdClasificacion.Value),
                Director = _utils.GetDirector(p.IdDirector.Value),
                Idioma = _utils.GetLanguage(p.IdIdioma.Value),
            };

            return peliculaDto;

        }

        public async Task<List<PeliculaDto>> ObtenerPeliculas()
        {
            var peliculas = await _repository.GetAll();

            var peliculasDto = peliculas.Select(p => new PeliculaDto
            {
                CodPelicula = p.CodPelicula,
                Titulo = p.Titulo,
                FechaEstreno = p.FechaEstreno,
                DuracionMin = p.DuracionMin,
                Portada = p.Portada,
                Genero = _utils.GetGender(p.IdGenero.Value),
                ClasificacionEdad = _utils.GetClasification(p.IdClasificacion.Value),
                Director = _utils.GetDirector(p.IdDirector.Value),
                Idioma = _utils.GetLanguage(p.IdIdioma.Value),

            }).ToList();

            return peliculasDto;
        }
    }
}
