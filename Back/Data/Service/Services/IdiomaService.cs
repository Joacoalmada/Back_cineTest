using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;

namespace Back.Data.Service.Services
{
    public class IdiomaService : IIdiomaService
    {
        private readonly IDiomaRepository _repository;

        public IdiomaService(IDiomaRepository repository) 
        {
            _repository = repository;
        }

        public Task<List<Idioma>> ObtenerIdiomas()
        {
            return _repository.GetAll();
        }
    }
}
