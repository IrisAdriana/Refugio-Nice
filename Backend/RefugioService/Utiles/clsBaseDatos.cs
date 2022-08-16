using RefugioService.Objetos;
using System.Data;
using System.Data.SqlClient;

namespace RefugioService.Utiles
{
    public class clsBaseDatos
    {
        #region Metodos Publicos
        public Cuenta VerificarCuenta(string cuenta, string pwd)
        {

            Conexion conexion = new Conexion();

            Cuenta usrcuenta = new Cuenta();            
            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_Verificar_Cuenta", conexion.sqlConexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add(new SqlParameter("@cuenta", cuenta));
                    sqlCommand.Parameters.Add(new SqlParameter("@contrasena", pwd));
                    //sqlCommand.Parameters.Add("@nombres", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@Mensaje", SqlDbType.VarChar, 254).Direction = ParameterDirection.Output;

                    //sqlCommand.ExecuteNonQuery();

                    try
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (VerificaExisteCampoReader(reader, "ErrorMessage") == false)
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        //cuenta = new Cuenta();
                                        usrcuenta.IdUsuario = (Int32)reader["IdUsuario"];
                                        usrcuenta.Usuario = reader["Nombres"].ToString() + ' ' + reader["Apellidos"].ToString();
                                        usrcuenta.Email = reader["Email"].ToString();
                                        //lstcolor.Add(color);

                                    }
                                }
                                else
                                {
                                    throw new Exception("No existen colores");
                                }
                            }
                            else
                            {
                                if (reader.Read())
                                {
                                    throw new Exception(reader["ErrorMessage"].ToString());
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }





                    //MensajeError = sqlCommand.Parameters["@Mensaje"].Value.ToString();                  

                }
                conexion.CerrarConexion();
            }
            else
            {

            }
            return usrcuenta;
        }
        public List<clsColor> ListaColores()
        {
            
            Conexion conexion = new Conexion();

            clsColor color = null;
            List<clsColor> lstcolor =new List<clsColor>();
            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_ObtenerColores", conexion.sqlConexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    //sqlCommand.Parameters.Add(new SqlParameter("@idUsuario", IdUsuario));
                    //sqlCommand.Parameters.Add("@nombres", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@Mensaje", SqlDbType.VarChar, 254).Direction = ParameterDirection.Output;

                    //sqlCommand.ExecuteNonQuery();

                    try
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if(VerificaExisteCampoReader(reader, "ErrorMessage")==false)
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        color = new clsColor();
                                        color.IdColor = (Int32)reader["IdColor"];
                                        color.Color = reader["Color"].ToString();
                                        lstcolor.Add(color);

                                    }
                                }
                                else
                                {
                                    throw new Exception("No existen colores");
                                }
                            }
                            else
                            {
                                if (reader.Read())
                                {
                                    throw new Exception(reader["ErrorMessage"].ToString());
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                    
                    


                    //MensajeError = sqlCommand.Parameters["@Mensaje"].Value.ToString();                  

                }
                conexion.CerrarConexion();
            }
            else
            {

            }            
            return lstcolor;
        }

        public List<clsRaza> ListaRazas()
        {

            Conexion conexion = new Conexion();

            clsRaza raza = null;
            List<clsRaza> lstraza = new List<clsRaza>();
            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_ObtenerRazas", conexion.sqlConexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    //sqlCommand.Parameters.Add(new SqlParameter("@idUsuario", IdUsuario));
                    //sqlCommand.Parameters.Add("@nombres", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@Mensaje", SqlDbType.VarChar, 254).Direction = ParameterDirection.Output;

                    //sqlCommand.ExecuteNonQuery();

                    try
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (VerificaExisteCampoReader(reader, "ErrorMessage") == false)
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        raza = new clsRaza();
                                        raza.IdRaza = (Int32)reader["IdRaza"];
                                        raza.Raza = reader["Raza"].ToString();
                                        lstraza.Add(raza);

                                    }
                                }
                                else
                                {
                                    throw new Exception("No existen razas");
                                }
                            }
                            else
                            {
                                if (reader.Read())
                                {
                                    throw new Exception(reader["ErrorMessage"].ToString());
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }





                    //MensajeError = sqlCommand.Parameters["@Mensaje"].Value.ToString();                  

                }
                conexion.CerrarConexion();
            }
            else
            {

            }
            return lstraza;
        }

        public List<clsTipoMascota> ListaTiposMascotas()
        {

            Conexion conexion = new Conexion();

            clsTipoMascota tipomascota = null;
            List<clsTipoMascota> lstmascota = new List<clsTipoMascota>();
            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_ObtenerTipoMascota", conexion.sqlConexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    //sqlCommand.Parameters.Add(new SqlParameter("@idUsuario", IdUsuario));
                    //sqlCommand.Parameters.Add("@nombres", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@Mensaje", SqlDbType.VarChar, 254).Direction = ParameterDirection.Output;

                    //sqlCommand.ExecuteNonQuery();

                    try
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (VerificaExisteCampoReader(reader, "ErrorMessage") == false)
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        tipomascota = new clsTipoMascota();
                                        tipomascota.IdTipoMascota = (Int32)reader["IdTipoMascota"];
                                        tipomascota.TipoMascota = reader["TipoMascota"].ToString();
                                        lstmascota.Add(tipomascota);

                                    }
                                }
                                else
                                {
                                    throw new Exception("No existen tipos de mascotas");
                                }
                            }
                            else
                            {
                                if (reader.Read())
                                {
                                    throw new Exception(reader["ErrorMessage"].ToString());
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
                conexion.CerrarConexion();
            }
            else
            {

            }
            return lstmascota;
        }

        public List<clsMascota> ListaMascotas()
        {

            Conexion conexion = new Conexion();

            clsMascota mascota = null;
            List<clsMascota> lstmascota = new List<clsMascota>();
            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_ObtenerMascotas", conexion.sqlConexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    //sqlCommand.Parameters.Add(new SqlParameter("@idUsuario", IdUsuario));
                    //sqlCommand.Parameters.Add("@nombres", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, (64)).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output;
                    //sqlCommand.Parameters.Add("@Mensaje", SqlDbType.VarChar, 254).Direction = ParameterDirection.Output;

                    //sqlCommand.ExecuteNonQuery();

                    try
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (VerificaExisteCampoReader(reader, "ErrorMessage") == false)
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        mascota = new clsMascota();
                                        mascota.IdMascota = (Int32)reader["IdMascota"];
                                        mascota.Nombre = reader["Nombre"].ToString();
                                        mascota.Edad = reader["Edad"].ToString();
                                        mascota.TipoMascota = reader["TipoMascota"].ToString();
                                        mascota.Genero = reader["Genero"].ToString();
                                        mascota.Caracter = reader["Caracter"].ToString();
                                        mascota.Observaciones = reader["Observaciones"].ToString();
                                        mascota.Raza = reader["Raza"].ToString();
                                        mascota.Color = reader["Color"].ToString();
                                        mascota.URLFoto = reader["URLFoto"].ToString();
                                        lstmascota.Add(mascota);

                                    }
                                }
                                else
                                {
                                    throw new Exception("No existen mascotas");
                                }
                            }
                            else
                            {
                                if (reader.Read())
                                {
                                    throw new Exception(reader["ErrorMessage"].ToString());
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }





                    //MensajeError = sqlCommand.Parameters["@Mensaje"].Value.ToString();                  

                }
                conexion.CerrarConexion();
            }
            else
            {

            }
            return lstmascota;
        }


        #endregion
        #region Metodos privados
        private bool VerificaExisteCampoReader(SqlDataReader reader,string NombreCampo)
        {
            bool existeCampo=false;
            try
            {
                foreach (DataRow row in reader.GetSchemaTable().Rows) 
                {
                    if (row["ColumnName"].ToString() == NombreCampo)
                    {
                        existeCampo = true;
                        break;
                    }
                } 
                

            }
            catch (Exception ex)
            {
                existeCampo = false;
            }
            return existeCampo;
        }
        #endregion
    }
}
