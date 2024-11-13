using Back.Data.Models;

namespace Back.Utilities
{
    public class Utils : IUtils
    {
        CineDBContext _context;

        public Utils(CineDBContext context)
        {
            _context = context;
        }

        public string GetClasification(int id)
        {
            return _context.ClasificacionesEdads.First(c => c.IdClasificacion == id).Clasificacion;
        }

        public string GetDirector(int id)
        {
            var director = _context.Directores.First(d => d.IdDirector == id).Apellido + ' ' + _context.Directores.First(d => d.IdDirector == id).Nombre;
            return director;
        }

        public string GetGender(int id)
        {
            return _context.Generos.First(g => g.IdGenero == id).Genero1;
        }

        public string GetLanguage(int id)
        {
            return _context.Idiomas.First(i => i.IdIdioma == id).Idioma1;
        }
    }
}
