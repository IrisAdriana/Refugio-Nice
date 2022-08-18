namespace RefugioService.Objetos
{
    public class TiposRescate
    {
        public int idTipoRescate { get; set; }
        public string TipoRescate { get; set; }
        public TiposRescate()
        {
            idTipoRescate = 0;
            TipoRescate = string.Empty;
        }
    }
}
