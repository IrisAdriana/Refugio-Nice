namespace RefugioService.Objetos
{
    public class clsTipoMascota
    {
        public int IdTipoMascota { get; set; }
        public string TipoMascota { get; set; }
        public clsTipoMascota()
        {
            IdTipoMascota = 0;
            TipoMascota = String.Empty;
        }
    }
}
