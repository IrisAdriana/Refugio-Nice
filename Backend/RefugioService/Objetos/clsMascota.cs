namespace RefugioService.Objetos
{
    public class clsMascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public string TipoMascota { get; set; }
        public string Color { get; set; }
        public string Raza { get; set; }
        public string Edad { get; set; }
        public string Genero { get; set; }
        public string Caracter { get; set; }
        public string Observaciones { get; set; }
        public string URLFoto { get; set; }

        public clsMascota()
        {
            IdMascota = 0;
            Nombre = String.Empty;
            TipoMascota = String.Empty;
            Color = String.Empty;
            Raza = String.Empty;
            Edad = String.Empty;
            Genero = String.Empty;
            Caracter = String.Empty;
            Observaciones = String.Empty;
            URLFoto = String.Empty;
        }

    }
}
