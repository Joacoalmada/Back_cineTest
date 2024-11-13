using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;

namespace Back.Data.Service.Services
{
    public class SalaService : ISalaService
    {
        private readonly ISalaRepository _repository;

        public SalaService(ISalaRepository repository) 
        {
            _repository = repository;
        }
        public Task<List<Sala>> ObtenerSalas()
        {
            return _repository.GetAll();
        }
    }
}
