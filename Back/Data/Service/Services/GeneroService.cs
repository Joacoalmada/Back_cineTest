using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;

namespace Back.Data.Service.Services
{
    public class GeneroService : IGeneroService
    {
        private readonly IGeneroRepository _repository;

        public GeneroService(IGeneroRepository repository) 
        { 
            _repository = repository;
        }
        public Task<List<Genero>> ObtenerGeneros()
        {
            return _repository.GetAll();
        }
    }
}
