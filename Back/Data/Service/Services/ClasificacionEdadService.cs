using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;

namespace Back.Data.Service.Services
{
    public class ClasificacionEdadService : IClasificacionEdadService
    {
        private readonly IClasificacionEdad _repository;

        public ClasificacionEdadService(IClasificacionEdad service) 
        {
            _repository = service;
        }

        public Task<List<ClasificacionesEdad>> TraerClasificacionEdad()
        {
            return _repository.GetAll();
        }
    }
}
