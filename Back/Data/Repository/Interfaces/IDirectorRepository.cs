using Back.Data.Models;

namespace Back.Data.Repository.Interfaces
{
    public interface IDirectorRepository
    {
        Task<List<Directore>> GetAll();
    }
}
