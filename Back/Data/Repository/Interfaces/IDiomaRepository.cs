using Back.Data.Models;

namespace Back.Data.Repository.Interfaces
{
    public interface IDiomaRepository
    {
        Task<List<Idioma>> GetAll();
    }
}
