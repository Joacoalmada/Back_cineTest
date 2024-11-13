using Back.Data.Models;

namespace Back.Data.Repository.Interfaces
{
    public interface ITpFuncionRepository
    {
        Task<List<TiposFuncion>> GetAll();
    }
}
