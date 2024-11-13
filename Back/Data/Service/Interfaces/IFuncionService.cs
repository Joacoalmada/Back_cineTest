using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface IFuncionService
    {
        Task<List<FuncionesDto>> ObtenerFunciones();
        Task<FuncionesDto>? ObtenerFuncionesPorId(int id);
        Task<List<FuncionesDto>> ObtenerFuncionesPorDia(int dia);
        Task<bool> Guardar(Funcione funcione);
        Task<bool> Eliminar(int id);
    }
}
