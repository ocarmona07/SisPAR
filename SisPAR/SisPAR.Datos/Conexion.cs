namespace SisPAR.Datos
{
    using System.Data.SqlClient;

    /// <summary>
    /// Clase de conexión a la base de datos
    /// </summary>
    public class Conexion
    {
        /// <summary>
        /// Conexión SQL a la BD "SisPAR"
        /// </summary>
        private const string ConexionBd = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnetdb.mdf;User Instance=true";

        public SqlConnection ConexionSql()
        {
            return new SqlConnection(ConexionBd);
        }
    }
}
