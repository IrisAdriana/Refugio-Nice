namespace RefugioService.Objetos
{
    public class Rescate
    {
        public int IdRescate { get; set; }
        public string Denunciante { get; set; }
        public string Telefono { get; set; }
        public int IdTipoRescate { get; set; }
        public string TipoRescate { get; set; }
        public string Estado { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
