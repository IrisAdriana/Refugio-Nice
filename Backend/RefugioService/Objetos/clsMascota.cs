namespace RefugioService.Objetos
{
    public class clsMascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public int IdTipoMascota { get; set; }
        public string TipoMascota { get; set; }
        public int IdColor { get; set; }
        public string Color { get; set; }
        public int IdRaza { get; set; }
        public string Raza { get; set; }
        public string Edad { get; set; }
        public string Genero { get; set; }
        public string Caracter { get; set; }
        public string Observaciones { get; set; }
        public string URLFoto { get; set; }
        public string Estado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }

        public clsMascota()
        {
            IdMascota = 0;
            Nombre = String.Empty;
            IdTipoMascota= 0;   
            TipoMascota = String.Empty;
            IdColor = 0;
            Color = String.Empty;
            IdRaza = 0;
            Raza = String.Empty;
            Edad = String.Empty;
            Genero = String.Empty;
            Caracter = String.Empty;
            Observaciones = String.Empty;
            URLFoto = String.Empty;
            Estado= String.Empty;
            FechaNacimiento=DateTime.Now;
            FechaRegistro = DateTime.Now;
        }

    }
}
