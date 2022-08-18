namespace RefugioService.Objetos
{
    public class TipoDocumento
    {
        public int idtipodocumento { get; set; }
        public string tipodocumento { get; set; }

        public string estado { get; set; }
        public TipoDocumento()
        {
            idtipodocumento= 0;
            tipodocumento = String.Empty;
            estado = String.Empty;
        }
    }
}
