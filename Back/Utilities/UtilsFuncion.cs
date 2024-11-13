using Back.Data.Models;

namespace Back.Utilities
{
    public class UtilsFuncion : IUtilsFuncion
    {

        CineDBContext _context;

        public UtilsFuncion(CineDBContext context) 
        {
            _context = context;
        }
        public string GetPelicula(int? id)
        {
            return _context.Peliculas.First(p => p.IdClasificacion == id).Titulo;
        }

        public string GetTipoFuncion(int? id)
        {
            return _context.TiposFuncions.First(p => p.IdTipoFuncion == id).Tipo;
        }
    }
}
