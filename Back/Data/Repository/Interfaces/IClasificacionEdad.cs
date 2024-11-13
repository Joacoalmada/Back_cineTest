using Back.Data.Models;

namespace Back.Data.Repository.Interfaces
{
    public interface IClasificacionEdad
    {
        Task<List<ClasificacionesEdad>> GetAll();
    }
}
