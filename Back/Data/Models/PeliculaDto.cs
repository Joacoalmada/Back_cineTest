namespace Back.Data.Models
{
    public class PeliculaDto
    {
        public int CodPelicula { get; set; }

        public string Titulo { get; set; }

        public DateTime? FechaEstreno { get; set; }

        public int? DuracionMin { get; set; }

        public string Portada { get; set; }

        public string Genero { get; set; }

        public string ClasificacionEdad { get; set; }

        public string Director { get; set; }

        public string Idioma { get; set; }
    }
}
