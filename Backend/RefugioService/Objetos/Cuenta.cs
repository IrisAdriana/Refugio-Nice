namespace RefugioService.Objetos
{
    public class Cuenta
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public Cuenta()
        {
            IdUsuario = 0;
            Usuario = String.Empty;
            Email = String.Empty;
        }
    }
}
