using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;

namespace Back.Data.Service.Services
{
    public class TpFuncionesService : ITpFuncionesService
    {
        private readonly ITpFuncionRepository _Repository;

        public TpFuncionesService(ITpFuncionRepository repository) 
        {
            _Repository = repository;
        }
        public Task<List<TiposFuncion>> ObtenerFunciones()
        {
            return _Repository.GetAll();
        }
    }
}
