namespace Back.Data.Models
{
    public class FuncionesDto
    {
        public int CodFuncion { get; set; }

        public TimeOnly? HoraInicio { get; set; }

        public decimal? Precio { get; set; }

        public bool? Subtitulo { get; set; }

        public int? Dia { get; set; }

        public string TituloPeli { get; set; }

        public int? IdSala { get; set; }

        public int? Promocion { get; set; }

        public string TipoFuncion { get; set; }

        public bool? Estado { get; set; }
    }
}
