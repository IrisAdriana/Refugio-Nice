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
            List<clsColor> lstcolor = new List<clsColor>();
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
                            if (VerificaExisteCampoReader(reader, "ErrorMessage") == false)
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

        public List<TipoDocumento> ListaTipoDocumento()
        {

            Conexion conexion = new Conexion();

            TipoDocumento tipodocumento = null;
            List<TipoDocumento> lsttipodocumento = new List<TipoDocumento>();
            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_ObtenerTipoDocumento", conexion.sqlConexion))
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
                                        tipodocumento = new TipoDocumento();
                                        tipodocumento.idtipodocumento = (Int32)reader["IdTipoDocumentoIdentidad"];
                                        tipodocumento.tipodocumento = reader["TipoDocumento"].ToString();
                                        tipodocumento.estado = "A";//reader["estado"].ToString();
                                        lsttipodocumento.Add(tipodocumento);

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
            return lsttipodocumento;
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

        public void NuevaMascota(clsMascota mascota)
        {

            Conexion conexion = new Conexion();

            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_Insertar_Mascotas", conexion.sqlConexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add(new SqlParameter("@Nombre", mascota.Nombre));
                    sqlCommand.Parameters.Add(new SqlParameter("@IdTipoMascota", mascota.IdTipoMascota));
                    sqlCommand.Parameters.Add(new SqlParameter("@IdColor", mascota.IdColor));
                    sqlCommand.Parameters.Add(new SqlParameter("@IdRaza", mascota.IdRaza));
                    sqlCommand.Parameters.Add(new SqlParameter("@FechaNacimiento", mascota.FechaNacimiento));
                    sqlCommand.Parameters.Add(new SqlParameter("@Edad", mascota.Edad));
                    sqlCommand.Parameters.Add(new SqlParameter("@Genero", mascota.Genero));
                    sqlCommand.Parameters.Add(new SqlParameter("@Caracter", mascota.Caracter));
                    sqlCommand.Parameters.Add(new SqlParameter("@Observaciones", mascota.Observaciones));
                    sqlCommand.Parameters.Add(new SqlParameter("@FechaRegistro", mascota.FechaRegistro));
                    sqlCommand.Parameters.Add(new SqlParameter("@URLFoto", mascota.URLFoto));
                    sqlCommand.Parameters.Add(new SqlParameter("@Estado", mascota.Estado));

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
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

        }

        public List<TiposRescate> ListaTiposRescates()
        {

            Conexion conexion = new Conexion();

            TiposRescate tiporescate = null;
            List<TiposRescate> lsttiporescate = new List<TiposRescate>();
            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_ObtenerTiposRescates", conexion.sqlConexion))
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
                                        tiporescate = new TiposRescate();
                                        tiporescate.idTipoRescate = (Int32)reader["IdTipoRescate"];
                                        tiporescate.TipoRescate = reader["TipoRescate"].ToString();
                                        lsttiporescate.Add(tiporescate);

                                    }
                                }
                                else
                                {
                                    throw new Exception("No existen tipos de rescate");
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
            return lsttiporescate;
        }

        public List<Rescate> ListaRescates()
        {

            Conexion conexion = new Conexion();

            Rescate rescate = null;
            List<Rescate> lstrescate = new List<Rescate>();
            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_ObtenerRescates", conexion.sqlConexion))
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
                                        rescate = new Rescate();
                                        rescate.IdRescate = (Int32)reader["IdRescate"];
                                        rescate.Denunciante = reader["Denunciante"].ToString();
                                        rescate.Telefono = reader["Telefono"].ToString();
                                        rescate.IdTipoRescate = (Int32)reader["IdTipoRescate"];
                                        rescate.TipoRescate = reader["TipoRescate"].ToString();
                                        rescate.Estado = reader["Estado"].ToString();
                                        rescate.Observacion = reader["Observacion"].ToString();
                                        rescate.Latitud = (float)reader["Latidud"];
                                        rescate.Longitud = (float)reader["Longitud"];
                                        lstrescate.Add(rescate);

                                    }
                                }
                                else
                                {
                                    throw new Exception("No existen rescatew");
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
            return lstrescate;
        }

        public void NuevoRescate(Rescate rescate)
        {

            Conexion conexion = new Conexion();

            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_Insertar_Rescates", conexion.sqlConexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add(new SqlParameter("@Denunciante", rescate.Denunciante));
                    sqlCommand.Parameters.Add(new SqlParameter("@Telefono", rescate.Telefono));
                    sqlCommand.Parameters.Add(new SqlParameter("@IdTipoRescate", rescate.IdTipoRescate));
                    sqlCommand.Parameters.Add(new SqlParameter("@Estado", rescate.Estado));
                    sqlCommand.Parameters.Add(new SqlParameter("@Latitud", rescate.Latitud));
                    sqlCommand.Parameters.Add(new SqlParameter("@Longitud", rescate.Longitud));
                    sqlCommand.Parameters.Add(new SqlParameter("@Observacion", rescate.Observacion));
                    sqlCommand.Parameters.Add(new SqlParameter("@FechaRegistro", rescate.FechaRegistro));

                    try
                    {
                        //var resp=sqlCommand.ExecuteNonQuery();//devuleve nro de filas afectadas
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if(reader.FieldCount>=0)
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

        }


        public void NuevoSolicitud(Solicitud solicitud)
        {

            Conexion conexion = new Conexion();

            string MensajeError = string.Empty;


            if (conexion.sqlConexion.State == ConnectionState.Open)
            {
                using (SqlCommand sqlCommand = new SqlCommand("SP_Insertar_SolicitudH", conexion.sqlConexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.Add(new SqlParameter("@Solicitante", solicitud.Solicitante));
                    sqlCommand.Parameters.Add(new SqlParameter("@IdTipoDocumentoIdentidad", solicitud.IdTipoDocumentoIdentidad));
                    sqlCommand.Parameters.Add(new SqlParameter("@DocumentoIdentidad", solicitud.Documento));
                    sqlCommand.Parameters.Add(new SqlParameter("@FechaNacimiento", solicitud.FechaNacimiento));
                    sqlCommand.Parameters.Add(new SqlParameter("@Telefono", solicitud.Telefono));
                    sqlCommand.Parameters.Add(new SqlParameter("@Direccion", solicitud.Direccion));
                    sqlCommand.Parameters.Add(new SqlParameter("@Email", solicitud.Email));
                    sqlCommand.Parameters.Add(new SqlParameter("@FechaRegistro", solicitud.FechaRegistro));
                    sqlCommand.Parameters.Add(new SqlParameter("@IdMascota", solicitud.IdMascota));
                    sqlCommand.Parameters.Add(new SqlParameter("@Estado", solicitud.Estado));

                    try
                    {
                        //var resp=sqlCommand.ExecuteNonQuery();//devuleve nro de filas afectadas
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.FieldCount >= 0)
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

        }

        #endregion
        #region Metodos privados
        private bool VerificaExisteCampoReader(SqlDataReader reader, string NombreCampo)
        {
            bool existeCampo = false;
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

