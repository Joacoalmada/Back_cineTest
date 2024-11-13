using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;

namespace Back.Data.Service.Services
{
    public class DirectoresService : IDirectorService
    {
        private readonly IDirectorRepository _repository;

        public DirectoresService(IDirectorRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Directore>> ObtenerDirectores()
        {
            return _repository.GetAll();
        }
    }
}
