using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;
using Back.Utilities;

namespace Back.Data.Service.Services
{
    public class FuncionService : IFuncionService
    {
        private readonly IFuncionRepository _repository;
        private readonly IUtilsFuncion _utils;
        public FuncionService(IFuncionRepository repository, IUtilsFuncion utils)
        {
            _repository = repository;
            _utils = utils;
        }

        public Task<bool> Eliminar(int id)
        {
            return _repository.Delete(id);
        }

        public Task<bool> Guardar(Funcione funcione)
        {
            return _repository.Save(funcione);
        }

        public async Task<List<FuncionesDto>> ObtenerFunciones()
        {
            var ap = await _repository.GetAll();

            var FuncionessDto = ap.Select(p => new FuncionesDto
            {
                CodFuncion = p.CodFuncion,
                HoraInicio = p.HoraInicio,
                Precio = p.Precio,
                Subtitulo = p.Subtitulo,
                Dia = p.Dia,
                TituloPeli = _utils.GetPelicula(p.CodPelicula.Value),
                IdSala = p.IdSala,
                Promocion = p.CodPromocion,
                TipoFuncion = _utils.GetTipoFuncion(p.IdTipoFuncion.Value),
                Estado = p.Estado


            }).ToList();
            return FuncionessDto;
            
        }

        public async Task<List<FuncionesDto>> ObtenerFuncionesPorDia(int dia)
        {
            var ap = await _repository.GetByDay(dia);

            var FuncionessDto = ap.Select(p => new FuncionesDto
            {
                CodFuncion = p.CodFuncion,
                HoraInicio = p.HoraInicio,
                Precio = p.Precio,
                Subtitulo = p.Subtitulo,
                Dia = p.Dia,
                TituloPeli = _utils.GetPelicula(p.CodPelicula.Value),
                IdSala = p.IdSala,
                Promocion = p.CodPromocion,
                TipoFuncion = _utils.GetTipoFuncion(p.IdTipoFuncion.Value),
                Estado = p.Estado


            }).ToList();
            return FuncionessDto;
        }

        public async Task<FuncionesDto>? ObtenerFuncionesPorId(int id)
        {
            var ap = await _repository.GetById(id);

            var FuncionessDto = new FuncionesDto()
            {
                CodFuncion = ap.CodFuncion,
                HoraInicio = ap.HoraInicio,
                Precio = ap.Precio,
                Subtitulo = ap.Subtitulo,
                Dia = ap.Dia,
                TituloPeli = _utils.GetPelicula(ap.CodPelicula.Value),
                IdSala = ap.IdSala,
                Promocion = ap.CodPromocion,
                TipoFuncion = _utils.GetTipoFuncion(ap.IdTipoFuncion.Value),
                Estado = ap.Estado


            };
            return FuncionessDto;
        }
    }
}
