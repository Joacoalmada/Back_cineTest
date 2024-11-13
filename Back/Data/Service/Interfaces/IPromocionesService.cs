using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface IPromocionesService
    {
        Task<List<Promocione>> ObtenerPromociones();
    }
}
