using System.Data.SqlClient;

namespace SisPAR.Datos
{

    using System;
    using System.Configuration;
    using System.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entidades;

    /// <summary>
    /// Clase de datos Tipo de Procesos
    /// </summary>
    public class TipoProcesosDa
    {
        
        public bool CrearTipoProceso(TPR_TIPO_PROCESO tipoProceso)
        {
            try
            {
                var conexionBd = new SqlConnection("data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnetdb.mdf;User Instance=true");
                var comandoSql = new SqlCommand("SELECT * FROM TPR_TIPOPROCESOS", conexionBd);
                comandoSql.Connection.Open();
                comandoSql.ExecuteNonQuery();
                comandoSql.Connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            
            return true;
        }
    }
}
