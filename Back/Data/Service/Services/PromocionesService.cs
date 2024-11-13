using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;

namespace Back.Data.Service.Services
{
    public class PromocionesService : IPromocionesService
    {
        private readonly IPromocionesRespository _repository;

        public PromocionesService(IPromocionesRespository repository)
        {
            _repository = repository;
        }

        public Task<List<Promocione>> ObtenerPromociones()
        {
            return _repository.GetAll();
        }
    }
}
