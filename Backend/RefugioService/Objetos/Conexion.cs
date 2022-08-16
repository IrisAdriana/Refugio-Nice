using System.Data.SqlClient;

namespace RefugioService.Objetos
{
    public class Conexion
    {
        public SqlConnection sqlConexion { get; set; }
        #region Métodos Publicos
        public Conexion()
        {
            AbrirConexion();

        }
        public void CerrarConexion()
        {
            sqlConexion.Dispose();
            sqlConexion.Close();
        }
        #endregion
        #region Métodos Privados
        private void AbrirConexion()
        {
            string cadenaConexion = "data source = localhost; initial catalog = Refugio; Integrated Security = True";
            sqlConexion = new SqlConnection(cadenaConexion);
            sqlConexion.Open();
        }
        #endregion
    }
}
