using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface IClasificacionEdadService
    {
        Task<List<ClasificacionesEdad>> TraerClasificacionEdad();
    }
}
