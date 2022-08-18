namespace RefugioService.Objetos
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public string Solicitante { get; set; }
        public int IdTipoDocumentoIdentidad { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono{ get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdMascota { get; set; }
        public string Estado { get; set; }

    }
}
