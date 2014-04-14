namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using Entidades;

    /// <summary>
    /// Clase de datos Tipo de Procesos
    /// </summary>
    public class RequerimientoDa
    {
        SisPAREntities dbSisPAR;

        public RequerimientoDa()
        {
            if (dbSisPAR == null)
            {
                dbSisPAR = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Tipo de Proceso
        /// </summary>
        /// <param name="requerimiento">Datos del Requerimiento</param>
        /// <returns>Id de confirmación</returns>
        public int CrearTipoProceso(REQ_REQUERIMIENTO requerimiento)
        {
            var idRetorno = -1;
            try
            {
                dbSisPAR.REQ_REQUERIMIENTO.AddObject(requerimiento);
                idRetorno = dbSisPAR.SaveChanges();
                dbSisPAR.Dispose();
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene todos los Tipos de Procesos
        /// </summary>
        /// <returns></returns>
        public List<TPR_TIPO_PROCESO> ObtenerTipoProcesos()
        {
            var listaRetorno = new List<TPR_TIPO_PROCESO>();
            try
            {
                var comandoSql = new SqlCommand("PA_ObtenerTipoProcesos", new Conexion().ConexionSql());
                comandoSql.CommandType = CommandType.StoredProcedure;
                comandoSql.Connection.Open();
                var listaReader = comandoSql.ExecuteReader();
                while (listaReader.Read())
                {
                    var tipoProceso = new TPR_TIPO_PROCESO();
                    tipoProceso.TPR_ID = Convert.ToInt32(listaReader["TPR_ID"]);
                    tipoProceso.TPR_DESCRIPCION = listaReader["TPR_DESCRIPCION"].ToString();
                    listaRetorno.Add(tipoProceso);
                }

                comandoSql.Connection.Close();
                comandoSql.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Tipo de Proceso
        /// </summary>
        /// <param name="tipoProceso">Datos del Tipo de Proceso</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarTipoProceso(TPR_TIPO_PROCESO tipoProceso)
        {
            var idRetorno = -1;
            try
            {
                var comandoSql = new SqlCommand("PA_ActualizarTipoProceso", new Conexion().ConexionSql());
                comandoSql.CommandType = CommandType.StoredProcedure;
                comandoSql.Parameters.Add("TPR_ID", SqlDbType.Int).Value = tipoProceso.TPR_ID;
                comandoSql.Parameters.Add("TPR_DESCRIPCION", SqlDbType.VarChar, 50).Value = tipoProceso.TPR_DESCRIPCION;
                comandoSql.Connection.Open();
                idRetorno = comandoSql.ExecuteNonQuery();
                comandoSql.Connection.Close();
                comandoSql.Dispose();
                return idRetorno;
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }

        /// <summary>
        /// Método que crea un Tipo de Proceso
        /// </summary>
        /// <param name="idTipoProceso">ID Tipo de Proceso</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarTipoProceso(int idTipoProceso)
        {
            var idRetorno = -1;
            try
            {
                var comandoSql = new SqlCommand("PA_EliminarTipoProceso", new Conexion().ConexionSql());
                comandoSql.CommandType = CommandType.StoredProcedure;
                comandoSql.Parameters.Add("TPR_ID", SqlDbType.Int).Value = idTipoProceso;
                comandoSql.Connection.Open();
                idRetorno = comandoSql.ExecuteNonQuery();
                comandoSql.Connection.Close();
                comandoSql.Dispose();
                return idRetorno;
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }
    }
}
