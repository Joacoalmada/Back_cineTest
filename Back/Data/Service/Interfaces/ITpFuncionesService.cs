using Back.Data.Models;

namespace Back.Data.Service.Interfaces
{
    public interface ITpFuncionesService
    {
        Task<List<TiposFuncion>> ObtenerFunciones();
    }
}
